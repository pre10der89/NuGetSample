#pragma once

#include <assert.h>
#include <math.h>
#include <stdarg.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>

#ifndef __cplusplus
#include <stdbool.h>
#endif

#include "AppCheckerMacros.h"
#include "AppCheckerEnums.h"

APPCHECKER_EXTERN_C_BEGIN

WIN_EXPORT ProcessorArchitecture GetArchitecture(void);
WIN_EXPORT Bitness GetBitness(void);
WIN_EXPORT Bitness GetBitnessByIntSize(void);
WIN_EXPORT OSType GetOSType(void);

WIN_EXPORT void Test(void);

BOOL IsWindows10OrGreaterLocal();

APPCHECKER_EXTERN_C_END