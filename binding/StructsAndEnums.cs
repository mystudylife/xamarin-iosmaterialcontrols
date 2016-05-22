using System;
using ObjCRuntime;

namespace MaterialControls
{
	[Native]
	public enum MDButtonType : long
	{
		Raised,
		Flat,
		FloatingAction,
		FloatingActionRotation
	}

	[Native]
	public enum MDProgressStyle : long
	{
		Circular,
		Linear
	}

	[Native]
	public enum MDProgressType : long
	{
		Indeterminate,
		Determinate
	}

	[Native]
	public enum MDTextFieldViewState : long
	{
		Normal,
		Highlighted,
		Error,
		Disabled
	}

	[Native]
	public enum MDGravity : long
	{
		None = 0,
		Top = 1 << 0,
		Bottom = 1 << 1,
		Left = 1 << 2,
		Right = 1 << 3,
		CenterHorizontal = 1 << 4,
		CenterVertical = 1 << 5
	}
}
