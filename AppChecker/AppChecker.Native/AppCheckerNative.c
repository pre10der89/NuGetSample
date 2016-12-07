#include <string.h>
#include <windows.h>
#include <tchar.h>
#include <VersionHelpers.h>
#include "AppCheckerNative.h"

typedef BOOL(WINAPI *IW64PFP)(HANDLE, BOOL *);

ProcessorArchitecture GetArchitecture(void)
{
	SYSTEM_INFO systemInfo;
	memset(&systemInfo, 0, sizeof(systemInfo));

	GetNativeSystemInfo(&systemInfo);

	ProcessorArchitecture architecture;

	switch (systemInfo.wProcessorArchitecture)
	{
	case PROCESSOR_ARCHITECTURE_IA64:
	case PROCESSOR_ARCHITECTURE_AMD64:
		architecture = X64;
		break;
	case PROCESSOR_ARCHITECTURE_INTEL:
		architecture = X86;
		break;
	case PROCESSOR_ARCHITECTURE_ARM:
		architecture = ARM;
		break;
	default:
		architecture = unknown_architecture;
	}

	return architecture;
}

Bitness GetBitness()
{
//#if defined(_WIN64)
//	return _64Bit;  // 64-bit programs run only on Win64
//#elif defined(_WIN32)
//	// 32-bit programs run on both 32-bit and 64-bit Windows
//	// so must sniff
//	BOOL f64 = FALSE;
//	if (IsWow64Process(GetCurrentProcess(), &f64) && f64)
//	{
//		return _64Bit;
//	}
//	else
//	{
//		return _32Bit;
//	}
//#endif

	BOOL res = FALSE;
	IW64PFP IW64P = (IW64PFP)GetProcAddress(
		GetModuleHandle(L"kernel32"), "IsWow64Process");

	if (IW64P != NULL) 
	{
		IW64P(GetCurrentProcess(), &res);

		return (res) ? _64Bit : _32Bit;
	}

	return unknown_bitness;
}

Bitness GetBitnessByIntSize()
{
	if ((size_t)-1 > 0xffffffffUL)
	{
		return _64Bit;
	}
	else
	{
		return _32Bit;
	}
}

OSType GetOSType(void)
{
	OSType osType;

	ProcessorArchitecture architecture = GetArchitecture();

	if (IsWindows7OrGreater() || IsWindows7SP1OrGreater() && !IsWindows8OrGreater())
	{
		switch (architecture)
		{
		case X64:
			osType = win7_x64;
			break;
		case X86:
			osType = win7_x64;
			break;
		case ARM:
			osType = win7_arm;
			break;
		default:
			osType = win7;
			break;
		}
	}
	else if (IsWindows8OrGreater() && !IsWindows8Point1OrGreater())
	{
		switch (architecture)
		{
		case X64:
			osType = win8_x64;
			break;
		case X86:
			osType = win8_x64;
			break;
		case ARM:
			osType = win8_arm;
			break;
		default:
			osType = win8;
			break;
		}
	}
	else if (IsWindows8Point1OrGreater() && !IsWindows10OrGreaterLocal())
	{
		switch (architecture)
		{
		case X64:
			osType = win81_x64;
			break;
		case X86:
			osType = win81_x64;
			break;
		case ARM:
			osType = win81_arm;
			break;
		default:
			osType = win81;
			break;
		}
	}
	else if (IsWindows10OrGreaterLocal())
	{
		switch (architecture)
		{
		case X64:
			osType = win10_x64;
			break;
		case X86:
			osType = win10_x64;
			break;
		case ARM:
			osType = win10_arm;
			break;
		default:
			osType = win10;
			break;
		}
	}

	return osType;
}

void Test()
{
	int k = 0;
}


BOOL IsWindows10OrGreaterLocal()
{
	return IsWindowsVersionOrGreater(HIBYTE(0x0A00), LOBYTE(0x0A00), 0);
}