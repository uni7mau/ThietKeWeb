// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const navbarComponent = document.getElementById('nwr_navbar');
const containerComponent = document.getElementById('nwr_container');

let lastScrollY = window.scrollY;

window.addEventListener('scroll', () => {
    const currentScrollY = window.scrollY;

    const containerRect = containerComponent.getBoundingClientRect();
    const containerTop = containerRect.top;

    const scrollDirection = currentScrollY > lastScrollY ? 'down' : 'up';

    if (scrollDirection === 'down' && containerTop < 0) {
        navbarComponent.classList.add('hide-on-scroll');
    } else if (scrollDirection === 'up' && containerTop < 0) {
        navbarComponent.classList.remove('hide-on-scroll');
    }

    lastScrollY = currentScrollY;
});