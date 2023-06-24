using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000064 RID: 100
[Token(Token = "0x2000064")]
internal class TreeFallState : NetworkState, ITreeFallState, IState, IDisposable
{
	// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x805C70", Offset = "0x804270", VA = "0x180805C70")]
	public TreeFallState()
	{
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000373 RID: 883 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001C7")]
	public NetworkTransform SectionATransform
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000374 RID: 884 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001C8")]
	public NetworkTransform SectionBTransform
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x805CD0", Offset = "0x8042D0", VA = "0x180805CD0", Slot = "32")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000375 RID: 885 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001C9")]
	public NetworkTransform SectionCTransform
	{
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x805D30", Offset = "0x804330", VA = "0x180805D30", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06000376 RID: 886 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001CA")]
	public NetworkTransform SectionDTransform
	{
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x805D90", Offset = "0x804390", VA = "0x180805D90", Slot = "34")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000377 RID: 887 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001CB")]
	public BoltEntity CutTree
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x805DF0", Offset = "0x8043F0", VA = "0x180805DF0", Slot = "35")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x805E90", Offset = "0x804490", VA = "0x180805E90", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000379 RID: 889 RVA: 0x00003378 File Offset: 0x00001578
	// (set) Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001CC")]
	public float UniformScale
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x8060F0", Offset = "0x8046F0", VA = "0x1808060F0", Slot = "37")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x806150", Offset = "0x804750", VA = "0x180806150", Slot = "38")]
		set
		{
		}
	}
}
