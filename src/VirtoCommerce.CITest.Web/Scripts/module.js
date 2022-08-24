// Call this to register your module to main application
var moduleName = 'CITest';

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('workspace.CITestState', {
                    url: '/CITest',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        'platformWebApp.bladeNavigationService',
                        function (bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: 'CITest.helloWorldController',
                                template: 'Modules/$(VirtoCommerce.CITest)/Scripts/blades/hello-world.html',
                                isClosingDisabled: true,
                            };
                            bladeNavigationService.showBlade(newBlade);
                        }
                    ]
                });
        }
    ])
    .run(['platformWebApp.mainMenuService', '$state',
        function (mainMenuService, $state) {
            //Register module in main menu
            var menuItem = {
                path: 'browse/CITest',
                icon: 'fa fa-cube',
                title: 'CITest',
                priority: 100,
                action: function () { $state.go('workspace.CITestState'); },
                permission: 'CITest:access',
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
