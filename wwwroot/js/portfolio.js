(() => {
    const setup = () => {
        const reducedMotion = window.matchMedia('(prefers-reduced-motion: reduce)').matches;
        const sections = [...document.querySelectorAll('main section[id]')];
        const navLinks = [...document.querySelectorAll('[data-section-link]')];

        if (!reducedMotion && 'IntersectionObserver' in window) {
            document.documentElement.classList.add('js-reveal');
            const revealObserver = new IntersectionObserver((entries, observer) => {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('is-visible');
                        observer.unobserve(entry.target);
                    }
                });
            }, { threshold: 0.12 });
            document.querySelectorAll('.reveal-section').forEach(section => revealObserver.observe(section));
        }

        if ('IntersectionObserver' in window) {
            const activeObserver = new IntersectionObserver(entries => {
                const visible = entries.filter(entry => entry.isIntersecting).sort((a, b) => b.intersectionRatio - a.intersectionRatio)[0];
                if (!visible) return;
                navLinks.forEach(link => {
                    const active = link.dataset.sectionLink === visible.target.id;
                    link.classList.toggle('active', active);
                    if (active) link.setAttribute('aria-current', 'location');
                    else link.removeAttribute('aria-current');
                });
            }, { rootMargin: '-20% 0px -65% 0px', threshold: [0, .2, .5] });
            sections.forEach(section => activeObserver.observe(section));
        }

        const menu = document.getElementById('portfolioNav');
        menu?.querySelectorAll('a[href^="#"]').forEach(link => link.addEventListener('click', () => {
            if (window.bootstrap && menu.classList.contains('show')) bootstrap.Collapse.getOrCreateInstance(menu).hide();
        }));
    };

    if (document.readyState === 'loading') document.addEventListener('DOMContentLoaded', setup, { once: true });
    else setup();
})();
