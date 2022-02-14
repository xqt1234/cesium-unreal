# EDIT THIS FILE! THIS IS SCAFFOLDING FOR YOU TO OWN!
# THIS FILE WAS ORIGINALLY GENERATED BY CONAN-UE4CLI VERSION 0.0.38.
from conans import ConanFile
import os

class CesiumNativeConan(ConanFile):
    settings = "os", "compiler", "build_type", "arch"
    generators = "json"
    
    def _requireUnreal(self, dependency):
        '''
        Adds a package as a dependency, filling in the Unreal Engine version string.
        
        Call this with a package reference that uses a placeholder for the channel, e.g.:
        self._requireUnreal("my-package/1.0.0@adamrehn/{}")
        '''
        self.requires(dependency.format(os.environ["UNREAL_ENGINE_VERSION"]))
    
    def requirements(self):
        # TODO:
        # LIST YOUR DEPENDENCIES HERE, USING THE `self._requireUnreal()` METHOD.
        # MAKE SURE YOU USE A PLACEHOLDER `{}` FOR THE PACKAGE CHANNEL, e.g.:
        # self._requireUnreal("my-package/1.0.0@adamrehn/{}")
        self._requireUnreal("Cesium3DTilesSelection/0.12.0@user/dev")
        self._requireUnreal("CesiumAsync/0.12.0@user/dev")
        self._requireUnreal("CesiumIonClient/0.12.0@user/dev")
        self._requireUnreal("CesiumUtility/0.12.0@user/dev")
