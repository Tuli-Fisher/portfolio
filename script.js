// Create animated starfield
function createStars() {
    const containers = [
        { el: document.getElementById('stars'), count: 150, size: 1 },
        { el: document.getElementById('stars2'), count: 100, size: 1.5 },
        { el: document.getElementById('stars3'), count: 50, size: 2 }
    ];

    containers.forEach(({ el, count, size }) => {
        const fragment = document.createDocumentFragment();
        for (let i = 0; i < count; i++) {
            const star = document.createElement('div');
            const opacity = 0.3 + Math.random() * 0.7;
            star.style.cssText = `
                position: absolute;
                width: ${size}px;
                height: ${size}px;
                background-color: white;
                border-radius: 50%;
                opacity: ${opacity};
                left: ${Math.random() * 100}%;
                top: ${Math.random() * 100}%;
                animation: twinkle ${2 + Math.random() * 3}s ease-in-out infinite;
                animation-delay: ${Math.random() * 3}s;
                box-shadow: 0 0 ${size * 2}px rgba(255, 255, 255, ${opacity});
            `;
            fragment.appendChild(star);
        }
        el.appendChild(fragment);
    });
}

// Smooth scrolling for navigation links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', (e) => {
        e.preventDefault();
        const target = document.querySelector(anchor.getAttribute('href'));
        if (target) {
            target.scrollIntoView({ behavior: 'smooth', block: 'start' });

            // Auto-show form when clicking contact link
            if (anchor.getAttribute('href') === '#contact') {
                setTimeout(() => {
                    const btn = document.getElementById('contact-me-btn');
                    const form = document.getElementById('contact-form');
                    if (form?.style.display === 'none') {
                        btn?.click();
                    }
                }, 500);
            }
        }
    });
});

// Navigation scroll shadow effect
const nav = document.querySelector('.nav');
window.addEventListener('scroll', () => {
    nav.style.boxShadow = window.pageYOffset > 100
        ? '0 5px 20px rgba(0, 212, 255, 0.2)'
        : 'none';
});

// Initialize everything when DOM is ready
document.addEventListener('DOMContentLoaded', () => {
    // Create starfield
    createStars();

    // Setup contact form
    const contactMeBtn = document.getElementById('contact-me-btn');
    const contactForm = document.getElementById('contact-form');
    const formStatus = document.getElementById('form-status');

    if (contactMeBtn && contactForm) {
        // Toggle form visibility
        contactMeBtn.addEventListener('click', () => {
            const isHidden = contactForm.style.display === 'none';
            contactForm.style.display = isHidden ? 'block' : 'none';

            if (isHidden) {
                contactForm.scrollIntoView({ behavior: 'smooth', block: 'nearest' });
                setTimeout(() => document.getElementById('name').focus(), 300);
            }
        });

        // Form submission
        contactForm.addEventListener('submit', async (e) => {
            e.preventDefault();

            const submitBtn = contactForm.querySelector('.submit-btn');
            const originalText = submitBtn.textContent;
            submitBtn.disabled = true;
            submitBtn.textContent = 'Sending...';
            formStatus.className = 'form-status';
            formStatus.textContent = '';

            try {
                const response = await fetch('https://api.web3forms.com/submit', {
                    method: 'POST',
                    body: new FormData(contactForm)
                });

                const data = await response.json();

                if (response.ok && data.success) {
                    formStatus.textContent = 'Message sent successfully! I\'ll get back to you soon.';
                    formStatus.className = 'form-status success';
                    contactForm.reset();

                    setTimeout(() => {
                        contactForm.style.display = 'none';
                        formStatus.className = 'form-status';
                    }, 3000);
                } else {
                    throw new Error(data.message || 'Failed to send message');
                }
            } catch (error) {
                formStatus.textContent = 'Error sending message. Please try again.';
                formStatus.className = 'form-status error';
                setTimeout(() => formStatus.className = 'form-status', 5000);
            } finally {
                submitBtn.disabled = false;
                submitBtn.textContent = originalText;
            }
        });
    }

    // Fade-in animation on scroll
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.opacity = '1';
                entry.target.style.transform = 'translateY(0)';
            }
        });
    }, { threshold: 0.1, rootMargin: '0px 0px -100px 0px' });

    document.querySelectorAll('.skill-card, .project-card, .about-text, .tech-icon').forEach(el => {
        el.style.opacity = '0';
        el.style.transform = 'translateY(30px)';
        el.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
        observer.observe(el);
    });

    // Project card expansion
    document.querySelectorAll('.project-card').forEach(card => {
        card.addEventListener('click', (e) => {
            // Don't trigger if clicking a link or button inside the card
            if (e.target.tagName === 'A' || e.target.tagName === 'BUTTON') return;

            card.classList.toggle('expanded');
        });
    });
});

// Add CSS animation for twinkling stars
const style = document.createElement('style');
style.textContent = `
    @keyframes twinkle {
        0%, 100% { opacity: 0.3; }
        50% { opacity: 1; }
    }
`;
document.head.appendChild(style);
