PJS.Atropos
===========
Atropos is clean, super flexible and has a fully responsive design!

Atropos is very intuitive, built with HTML5 & CSS3, and has a ton of awesome features. The clean design can be used for any type of website; business, corporate, portfolio, blog, products, etc.

Released under the [MIT License](http://opensource.org/licenses/mit-license.php)

## Screenshots

![Screenshot](https://raw.github.com/psenechal/PJS.Atropos/master/Theme.png)

## About the theme

* Theme options can be set via the Orchard Admin panel under Settings/Theme-Atropos.
* To enable media for Blog Posts, add a MediaLibraryPickerField to the BlogPost Part under Content Definition. Under the BlogPost Type, configure the MediaLibraryPickerField for single or multiple items. Multiple items will display in a carousel.
* Theme comes with two slider options for the homepage. Modify Slider1.cshtml or Slider2.cshtml under the Views folder of the theme to customize the slides. Choose which slider to display by modifying Insertions.cshtml, also under the Views folder.
* The navigation bar search field requires the Search module to be enabled. To remove the navigation bar search field, delete the @Display.NavSearch() line from Menu.cshtml.
* If using a header option that enables the Top Bar, customize the TopBar.cshtml file with your information.
* Theme comes with custom email templates for the Users module for Lost Password and Account Validation. There are some social media links in Template.User.Wrapper.cshtml that should be customized or removed.
* Favicon images were generated using [Real Favicon Generator](http://realfavicongenerator.net/).

## Installation

1. Just clone repository to your **Themes** directory in your Orchard installation.

	```
	git clone https://github.com/psenechal/pjs.atropos.git PJS.Atropos
	```

2. Login to your admin panel in your Orchard installation.
3. Go to Themes and click Set as current below the **PJS.Atropos**.

## Credits

**[stepofweb](https://wrapbootstrap.com/theme/atropos-responsive-website-template-WB05SR527)** - This project is a conversion of a standard HTML template to an Orchard CMS theme. In order to use this theme, please purchase a license from the template owner.

## History

* [2015-10-14] v1.7: Initial release.
