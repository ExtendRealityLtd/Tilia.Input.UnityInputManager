# Changelog

### [1.3.8](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.7...v1.3.8) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.23.0 to 1.24.0 ([bd117dc](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/bd117dca4dd2b4102d3e2694c57cb1613256d334))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.23.0 to 1.24.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.23.0...v1.24.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.7](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.6...v1.3.7) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.22.0 to 1.23.0 ([780f54c](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/780f54cb916a64b44abcd363708d38d5e84bb628))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.22.0 to 1.23.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.22.0...v1.23.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.6](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.5...v1.3.6) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.21.0 to 1.22.0 ([e822705](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/e822705364653d849514143eaeb0353384c868a6))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.21.0 to 1.22.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.21.0...v1.22.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.5](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.4...v1.3.5) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([e24919a](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/e24919ae2ea5a77e7de22c7f23046a921a0b2d14))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.4](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.3...v1.3.4) (2020-07-11)

#### Bug Fixes

* **ControllerMappings:** use horizontal/vertical axis for xbox mappings ([2dafa01](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/2dafa018b66ae650f4203d76954adcb399fe7346))
  > The Xbox controller left thumbstick works better when using the default Horizontal and Vertical axis mappings that come with Unity instead of the new custom Tilia Axis1 and Axis2 mapping so the prefab for the XBox Controller mappings have been switched back.

### [1.3.3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.2...v1.3.3) (2020-07-11)

#### Bug Fixes

* **AxisCreator:** add remove axis method and custom axis1 and axis2 ([4444968](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/4444968e2d45022f3c4649aa610f281b5d6ac5d2))
  > The Axis Creator now has a custom axis1 and axis2 which is used by the prefabs instead of relying on the Horizontal and Vertical axes provided by Unity as these are not clean axis settings.
  > 
  > The AxisCreator editor window also allows deleting of existing Tilia axis inputs so its easier to upgrade.
  > 
  > The incorrect negative multiplier in the controller mappings has also been removed now as the inversion happens on the axis setting in the Unity Input Manager.

### [1.3.2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.1...v1.3.2) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([2134499](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/213449928610ff4bb410f6ea3a2eae8cbb8ab1c8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.3.0...v1.3.1) (2020-07-07)

#### Bug Fixes

* **AxisCreator:** increase sensitivity for axis 4 and 5 ([38f386d](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/38f386d0760f345e18547b3733a111f68178038e))
  > Axis 4 and 5 generally relates to the right controller touchpad/thumbstick and if the sensitivity is too low then diagonal movement vectors seem multiplied. The Horizontal and Vertical axes have a sensitivity of `3` so this is now matching that setting.

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.14...v1.3.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([ba131d8](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/ba131d8b4c86a113478324f18a033ba61a4ee9b7))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([1b8ae27](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/1b8ae2770d9e99ac309a890cd725088b7cbacf31))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.2.14](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.13...v1.2.14) (2020-06-21)

#### Bug Fixes

* **Documentation:** apply template guidelines ([e14c759](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/e14c759494d4b503e0b909d8149312f5b2a21989))
  > The template guidelines have been applied to this documentation and the image quality has been improved.

### [1.2.13](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.12...v1.2.13) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([3398729](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/3398729c8da62bc50909f1877494adcd76e6ab21))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.12](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.11...v1.2.12) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([2bc4f41](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/2bc4f41b53e31f6f7131a0e6b965f54979ecbd2e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.11](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.10...v1.2.11) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([76e5ec2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/76e5ec231e37bb6c9128a54c389576059ecb8063))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.10](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.9...v1.2.10) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([eb789d3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/eb789d3b163cd650a7ecb391b2e03c12c8a5fd08))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.9](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.8...v1.2.9) (2020-05-21)

#### Bug Fixes

* **AxisCreator:** invert the right controller vertical axis ([63c036a](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/63c036ad946d0b85c19629e18120349efcfafe0c))
  > The Unity Axis5 data which is used for the right controller touchpad/thumbstick vertical axis needs to be inverted otherwise up gives a negative number which is opposite from the left controller which gives up a positive number.

### [1.2.8](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.7...v1.2.8) (2020-04-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.15.0 to 1.16.0 ([363a4dd](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/363a4dde732d3ca832afe150e1be438e47c4e7a1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.15.0 to 1.16.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.15.0...v1.16.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.7](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.6...v1.2.7) (2020-04-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.1 to 1.15.0 ([fc117dd](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/fc117dd64867d6551e75fb2061fc3fda0994e736))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.1 to 1.15.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.1...v1.15.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.6](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.5...v1.2.6) (2020-04-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.0 to 1.14.1 ([72b6f29](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/72b6f29933fb8209b6543357fefc296ff3195cdd))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.0 to 1.14.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.0...v1.14.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.5](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.4...v1.2.5) (2020-03-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.13.0 to 1.14.0 ([3776810](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/3776810bcf51e5e8ac5f17dd7e4edc3ad85d1b3a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.13.0 to 1.14.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.13.0...v1.14.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.4](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.3...v1.2.4) (2020-03-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.12.0 to 1.13.0 ([8ffb9a3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/8ffb9a3b81d0e45f2ecab43313f7be5f04d5fffa))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.12.0 to 1.13.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.12.0...v1.13.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.2...v1.2.3) (2020-02-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.11.0 to 1.12.0 ([c224b0e](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/c224b0efaec4e0dacb9a13463222d284ce763de1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.11.0 to 1.12.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.11.0...v1.12.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.1...v1.2.2) (2020-01-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.9.0 to 1.11.0 ([5cf1329](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/5cf1329c51c71454e2cf444cf5f2690abb951891))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.9.0 to 1.11.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.9.0...v1.11.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.1](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.2.0...v1.2.1) (2019-12-31)

#### Bug Fixes

* **FodyWeavers.xml:** move configuration to root directory ([cb1a731](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/cb1a73130e213c5e3a6d0f2b8bf70b5acb730778))
  > If there is more than one source directory then the FodyWeavers.xml configuration file should be in the root of the directory so multiple configuration files aren't required for each sources directory.

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.1.2...v1.2.0) (2019-12-04)

#### Features

* **HowToGuides:** show how to convert float action to boolean action ([63c1370](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/63c137054636c5956052bb9bf7169a03dfb8e08b))
  > showing how to convert float action to boolean action

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.1.1...v1.1.2) (2019-12-03)

#### Bug Fixes

* **HowToGuides:** add missing step to proxy action doc ([d849223](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/d849223011776fa70ca1dc1d45406ca6688392c8))
  > there was a part of step 2 missing from the document that didnt show the function that needed to be selected. a couple of the images were tidied up so that they didnt look as stretched.

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.1.0...v1.1.1) (2019-12-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.8.1 to 1.9.0 ([aae56ac](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/aae56ac0532296e35351ec886887d9bc5c602af3))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.8.1 to 1.9.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.8.1...v1.9.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.0.5...v1.1.0) (2019-11-28)

#### Features

* **HowToGuides:** add guide for proxy actions ([a46ae44](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/a46ae44b31d1dfe31273adaea6d5daefc5130bee))
  > added a guide for showing how to link actions together.

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.0.4...v1.0.5) (2019-11-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.8.0 to 1.8.1 ([196b645](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/196b6459f6f4518d738d1027f7114ddafaae1add))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.8.0 to 1.8.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.8.0...v1.8.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.0.3...v1.0.4) (2019-11-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.7.0 to 1.8.0 ([193d120](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/193d1209053381b131a802644fab649b9c8e705b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.7.0 to 1.8.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.7.0...v1.8.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.0.2...v1.0.3) (2019-11-07)

#### Bug Fixes

* **HowToGuides:** provide correct package name in installation guide ([dcc6ae2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/dcc6ae28c6f75529ae548b6d65825628adf3cb03))
  > The package name does not include dots and therefore should be written without any dot separators.
* **Prefabs:** provide correct axis number for oculus controller ([09cd8d6](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/09cd8d637e47f749b9ac91e1d88b89483815cd6e))
  > The axis number used on the Oculus Controller was incorrect and therefore causing the incorrect output when a different part of the controller was interacted with. This has now been rectified.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.0.1...v1.0.2) (2019-11-06)

#### Bug Fixes

* **Editor:** add asmdef file for editor scripts ([594bd5c](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/594bd5cf7322173c213047e56ffdfb4d0b78c384))
  > The Editor scripts were not being executed when the package was used due to no asmdef being present to load in the scripts. This has now been added.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/compare/v1.0.0...v1.0.1) (2019-11-06)

#### Bug Fixes

* **structure:** add missing .meta file ([a4ab10d](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/a4ab10d20cd6f0d0e417ddd8dcb5486a473dc1fd))
  > The CHANGELOG.md file is automatically created by the CI+CD system and therefore does not exist for Unity to create the .meta file for it until the release has occurred.
  > 
  > This fix manually adds in the missing .meta file.

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.6.0 to 1.7.0 ([352f79c](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/352f79ce90fcbf7068547d7a0b873092d8670fbe))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.6.0 to 1.7.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.6.0...v1.7.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## 1.0.0 (2019-11-05)

#### Features

* **structure:** create initial prefab and user guides ([69084ca](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/69084ca459a3fbdcca53ce94502465fbcfa653ff))
  > The structure of the repository has been created with all the required files for the package, the prefab and the documentation.

#### Bug Fixes

* **package:** add Editor directory to package include files ([c11ad4f](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/commit/c11ad4f7e421ca58d656c5e60a3fcd1aacbade0d))
  > The Editor directory should also be inlcuded in the package for a successful build.
