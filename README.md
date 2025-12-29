# Portfolio - Space Theme

A simple, elegant single-page portfolio website with a space-themed design.

## Quick Start

### Option 1: Open Directly
Simply double-click `index.html` to open it in your default browser.

### Option 2: Use a Local Server (Recommended)
For the best experience, especially when testing features:

**Using Python:**
```bash
python -m http.server 8000
```
Then open http://localhost:8000 in your browser.

**Or use the batch file:**
Double-click `start-server.bat` (Windows only)

**Using Node.js:**
```bash
npx serve
```

## Features

- **Single Page Application** - All content on one scrollable page
- **Space Theme** - Beautiful black background with animated stars and nebula effects
- **Interactive Elements** - Smooth scrolling, fade-in animations, and hover effects
- **Responsive Design** - Works on all device sizes
- **Contact Form** - Simple form for visitors to send messages
- **Project Showcase** - Display your featured projects with links
- **Skills Section** - Showcase your capabilities
- **GitHub Integration** - Easy links to your GitHub profile

## Customization

### Update GitHub Links
Replace `yourusername` in `index.html` with your actual GitHub username:
- Line 20: `<a href="https://github.com/yourusername" ...>`
- Line 158: `<a href="https://github.com/yourusername" ...>`

### Update Projects
Edit the projects section (starting around line 73) to add your own projects:
- Change project names
- Update descriptions
- Add your project and source code links

### Customize About Section
Update the about section (starting around line 48) with your own information and skills.

### Contact Form
The contact form currently shows a success message. To actually send emails, you'll need to:
1. Set up a backend service (e.g., using Formspree, EmailJS, or your own server)
2. Update the form submission handler in `script.js`

## Browser Support

Works in all modern browsers (Chrome, Firefox, Safari, Edge).
