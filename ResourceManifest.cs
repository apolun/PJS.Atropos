using Orchard.UI.Resources;

namespace PJS.Atropos {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // JAVASCRIPT FILES
            manifest.DefineScript("Modernizr").SetUrl("modernizr-2.7.1/modernizr.min.js").SetVersion("2.7.1");
            manifest.DefineScript("jQuery-Easing").SetUrl("jquery-easing-1.3/jquery.easing.1.3.js").SetVersion("1.3").SetDependencies("jQuery");
            manifest.DefineScript("jQuery-Cookie").SetUrl("jquery-cookie-1.4.1/jquery.cookie.js").SetVersion("1.4.1").SetDependencies("jQuery");
            manifest.DefineScript("jQuery-Appear").SetUrl("jquery-appear/jquery.appear.js").SetDependencies("jQuery");
            manifest.DefineScript("Isotope").SetUrl("isotope-2.2.2/isotope.pkgd.min.js", "isotope-2.2.2/isotope.pkgd.js").SetVersion("2.2.2").SetDependencies("jQuery");
            manifest.DefineScript("Masonry").SetUrl("masonry-3.3.2/masonry.pkgd.min.js", "masonry-3.3.2/masonry.pkgd.js").SetVersion("3.3.2").SetDependencies("jQuery");
            manifest.DefineScript("Bootstrap").SetUrl("bootstrap-3.3.5/bootstrap.min.js", "bootstrap-3.3.5/bootstrap.js").SetVersion("3.3.5").SetDependencies("jQuery");
            manifest.DefineScript("Magnific-Popup").SetUrl("magnific-popup-1.0.0/jquery.magnific-popup.min.js", "magnific-popup-1.0.0/jquery.magnific-popup.js").SetVersion("1.0.0").SetDependencies("jQuery");
            manifest.DefineScript("Owl-Carousel").SetUrl("owl-carousel-1.3.3/owl.carousel.min.js", "owl-carousel-1.3.3/owl.carousel.js").SetVersion("1.3.3").SetDependencies("jQuery");
            manifest.DefineScript("Stellar").SetUrl("stellar-0.6.2/jquery.stellar.min.js", "stellar-0.6.2/jquery.stellar.js").SetVersion("0.6.2").SetDependencies("jQuery");
            manifest.DefineScript("jQuery-Knob").SetUrl("jquery-knob-1.2.11/jquery.knob.min.js", "jquery-knob-1.2.11/jquery.knob.js").SetVersion("1.2.11").SetDependencies("jQuery");
            manifest.DefineScript("Backstretch").SetUrl("backstretch-2.0.4/jquery.backstretch.min.js").SetVersion("2.0.4").SetDependencies("jQuery");
            manifest.DefineScript("Superslides").SetUrl("superslides-0.6.3/jquery.superslides.min.js", "superslides-0.6.3/jquery.superslides.js").SetVersion("0.6.3").SetDependencies("jQuery");
            manifest.DefineScript("Media-Element").SetUrl("media-element-2.18.1/mediaelement-and-player.min.js", "media-element-2.18.1/mediaelement-and-player.js").SetVersion("2.18.1").SetDependencies("jQuery");
            manifest.DefineScript("Revslider").SetUrl("revslider-4.6.4/jquery.themepunch.revolution.min.js").SetVersion("4.6.4").SetDependencies("jQuery");
            manifest.DefineScript("Revslider-Tools").SetUrl("revslider-4.6.4/jquery.themepunch.tools.min.js").SetVersion("4.6.4").SetDependencies("jQuery");
            manifest.DefineScript("Slider-Revolution").SetUrl("revslider-4.6.4/slider_revolution.js").SetDependencies("jQuery");
            manifest.DefineScript("Atropos").SetUrl("scripts.js").SetVersion("1.7").SetDependencies("jQuery");
            manifest.DefineScript("Custom").SetUrl("custom.js").SetDependencies("jQuery");

            // CORE CSS
            manifest.DefineStyle("Bootstrap").SetUrl("bootstrap-3.3.5/css/bootstrap.min.css", "bootstrap-3.3.5/css/bootstrap.css").SetVersion("3.3.5");
            manifest.DefineStyle("Font-Awesome").SetUrl("font-awesome-4.4.0/css/font-awesome.min.css", "font-awesome-4.4.0/css/font-awesome.css").SetVersion("4.4.0");
            manifest.DefineStyle("Owl-Carousel").SetUrl("owl-carousel-1.3.3/owl.carousel.css").SetVersion("1.3.3");
            manifest.DefineStyle("Owl-Theme").SetUrl("owl-carousel-1.3.3/owl.theme.css").SetVersion("1.3.3");
            manifest.DefineStyle("Owl-Transitions").SetUrl("owl-carousel-1.3.3/owl.transitions.css").SetVersion("1.3.3");
            manifest.DefineStyle("Magnific-Popup").SetUrl("magnific-popup-1.0.0/magnific-popup.css").SetVersion("1.0.0");
            manifest.DefineStyle("Animate").SetUrl("animate/animate.min.css", "animate/animate.css");
            manifest.DefineStyle("Superslides").SetUrl("superslides-0.6.3/superslides.css").SetVersion("0.6.3");

            // REVOLUTION SLIDER
            manifest.DefineStyle("Revslider").SetUrl("revslider-4.6.4/css/settings.css").SetVersion("4.6.4");

            // THEME CSS
            manifest.DefineStyle("Essentials").SetUrl("essentials.css");
            manifest.DefineStyle("Layout").SetUrl("layout.css");
            manifest.DefineStyle("Layout-Dark").SetUrl("layout-dark.css");
            manifest.DefineStyle("Layout-Responsive").SetUrl("layout-responsive.css");
        }
    }
}