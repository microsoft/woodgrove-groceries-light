function stepUpProductFilter() {
    document.addEventListener('DOMContentLoaded', function () {
        const categoryFilter = document.getElementById('categoryFilter');
        const searchInput = document.getElementById('searchInput');
        const products = document.querySelectorAll('.product-item');

        function filterProducts() {
            const selectedCategory = categoryFilter.value.toLowerCase();
            const searchTerm = searchInput.value.toLowerCase();

            products.forEach(product => {
                const productCategory = product.dataset.category.toLowerCase();
                const productName = product.dataset.name;
                const matchesCategory = !selectedCategory || productCategory === selectedCategory;
                const matchesSearch = !searchTerm || productName.includes(searchTerm);

                if (matchesCategory && matchesSearch) {
                    product.style.display = '';
                } else {
                    product.style.display = 'none';
                }
            });
        }

        categoryFilter.addEventListener('change', filterProducts);
        searchInput.addEventListener('input', filterProducts);
    });
}


stepUpProductFilter();

