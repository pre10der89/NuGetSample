#pragma once

#ifdef __cplusplus
#define APPCHECKER_EXTERN_C_BEGIN extern "C" {
#define APPCHECKER_EXTERN_C_END }
#else
#define APPCHECKER_EXTERN_C_BEGIN
#define APPCHECKER_EXTERN_C_END
#endif

#ifdef _WINDLL
#define WIN_EXPORT __declspec(dllexport)
#else
#define WIN_EXPORT
#endif