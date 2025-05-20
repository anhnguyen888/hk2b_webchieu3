
        // Mobile Navigation Toggle
        document.addEventListener('DOMContentLoaded', function() {
            // Add smooth scrolling
            document.querySelectorAll('a[href^="#"]').forEach(anchor => {
                anchor.addEventListener('click', function (e) {
                    e.preventDefault();
                    
                    document.querySelector(this.getAttribute('href')).scrollIntoView({
                        behavior: 'smooth'
                    });
                });
            });
            
            // Add to cart functionality
            const addToCartButtons = document.querySelectorAll('.btn-add-cart');
            addToCartButtons.forEach(button => {
                button.addEventListener('click', function() {
                    const productName = this.parentElement.querySelector('.product-title').textContent;
                    alert(`${productName} added to cart!`);
                });
            });
            
            // Responsive navigation
            const navbarToggler = document.querySelector('.navbar-toggler');
            if (navbarToggler) {
                navbarToggler.addEventListener('click', function() {
                    document.querySelector('#navbarContent').classList.toggle('show');
                });
            }
        });