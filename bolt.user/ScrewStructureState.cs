using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
internal class ScrewStructureState : NetworkState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x8247D0", Offset = "0x822DD0", VA = "0x1808247D0")]
	public ScrewStructureState()
	{
	}

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x0600068F RID: 1679 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003AB")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x06000690 RID: 1680 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003AC")]
	public BoltEntity TranslationController
	{
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x824830", Offset = "0x822E30", VA = "0x180824830", Slot = "33")]
		set
		{
		}
	}
}
