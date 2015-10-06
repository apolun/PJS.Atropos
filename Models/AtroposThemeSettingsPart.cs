using Orchard.ContentManagement;

namespace PJS.Atropos.Models {
    public class AtroposThemeSettingsPart : ContentPart {
        public string Color {
            get { return this.Retrieve(r => r.Color, "orange"); } // orange, red, pink, yellow, darkgreen, green, darkblue, blue, brown, lightgrey
            set { this.Store(r => r.Color, value); }
        }
        public string Skin {
            get { return this.Retrieve(r => r.Skin, "light"); } // light, dark
            set { this.Store(r => r.Skin, value); }
        }
        public string LayoutStyle {
            get { return this.Retrieve(r => r.LayoutStyle, "wide"); } // wide, boxed
            set { this.Store(r => r.LayoutStyle, value); }
        }
        public string Background {
            get { return this.Retrieve(r => r.Background, "none"); } // pattern1, pattern2, pattern3, pattern4, pattern5, pattern6, pattern7, pattern8, pattern9, pattern10, img1, img2, img3, img4
            set { this.Store(r => r.Background, value); }
        }
        public string HeaderStyle {
            get { return this.Retrieve(r => r.HeaderStyle, "1"); } // 1, 2, 3, 4
            set { this.Store(r => r.HeaderStyle, value); }
        }
        public string BlogStyle {
            get { return this.Retrieve(r => r.BlogStyle, "standard"); } // standard, timeline, masonry
            set { this.Store(r => r.BlogStyle, value); }
        }
    }
}