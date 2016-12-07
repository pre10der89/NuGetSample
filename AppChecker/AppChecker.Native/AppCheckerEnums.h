typedef enum ProcessorArchitecture
{
	unknown_architecture = 0,
	X86 = 1,
	X64 = 2,
	ARM = 3
} ProcessorArchitecture;

typedef enum Bitness
{
	unknown_bitness,
	_32Bit,
	_64Bit
} Bitness;

typedef enum OSType
{
	unknown_ostype,
	win7,
	win7_x86,
	win7_x64,
	win7_arm,
	win8,
	win8_x86,
	win8_x64,
	win8_arm,
	win81,
	win81_x86,
	win81_x64,
	win81_arm,
	win10,
	win10_x86,
	win10_x64,
	win10_arm,
} OSType;