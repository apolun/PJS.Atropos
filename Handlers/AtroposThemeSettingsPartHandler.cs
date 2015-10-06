using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using PJS.Atropos.Models;

namespace PJS.Atropos.Handlers {
    [UsedImplicitly]
    public class AtroposThemeSettingsPartHandler : ContentHandler {
        public AtroposThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<AtroposThemeSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<AtroposThemeSettingsPart>("AtroposThemeSettings", "Parts/AtroposThemeSettings", "Theme-Atropos"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme-Atropos")));
        }
    }
}