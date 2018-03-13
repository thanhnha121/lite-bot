var LiteBot = angular.module("LiteBot", []).run(['$http', '$rootScope', function ($http, $rootScope) {

    $rootScope.initLang = function() {
        var lang = $.cookie(window.location.hostname + '-lang');
        if (lang === 'vn') {
            $rootScope.Lang = vnLangPack;
        } else {
            $rootScope.Lang = enLangPack;
        }
    };

    $rootScope.initLang();

    $rootScope.changeLang = function (lang) {
        $.cookie(window.location.hostname + '-lang', lang);
        $rootScope.initLang();
    };

}]);

LiteBot.directive("language", function () {
    return {
        restrict: 'E',
        template: `
            <button class="uk-button uk-button-default uk-float-left" type="button"><i class="{{Lang.Name + '-flag-icon'}}"></i>{{Lang.LangDerirective.ButtonTitle}}</button>
            <div uk-dropdown="mode: click">
                <ul class="uk-nav uk-dropdown-nav">
                    <li ng-click="$root.changeLang('en')"><i class='en-flag-icon'></i><a href="#">English</a></li>
                    <li ng-click="$root.changeLang('vn')"><i class='vn-flag-icon'></i><a href="#">Vietnamese</a></li>
                </ul>
            </div>
        `
    };
});