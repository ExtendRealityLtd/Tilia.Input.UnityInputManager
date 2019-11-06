# Changelog

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
