using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	[AddComponentMenu("Sons/Construction/FakeBeamStructure")]
	public class FakeBeamStructure : BeamStructure, IRampSupport, ITileSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IBeamSupport, IPilarSupport, IApexSupport, IWallSupport, IBridgeRopeSupport, IFloorSupport, IClimbRopeSupport, ISingleStepSupport
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x1700026E")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x2E72BB0", Offset = "0x2E711B0", VA = "0x182E72BB0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700026F")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x2E72BC0", Offset = "0x2E711C0", VA = "0x182E72BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x2E72C10", Offset = "0x2E71210", VA = "0x182E72C10", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00005FB4 File Offset: 0x000041B4
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "120")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00005FCC File Offset: 0x000041CC
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "115")]
		private bool CanHostNewRamp()
		{
			return default(bool);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "126")]
		private bool CanHostNewPilar(bool advancedBuildMode)
		{
			return default(bool);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00005FFC File Offset: 0x000041FC
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "137")]
		private bool CanHostNewApex()
		{
			return default(bool);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00006014 File Offset: 0x00004214
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "141")]
		private bool CanHostNewWall()
		{
			return default(bool);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0000602C File Offset: 0x0000422C
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "148")]
		private bool CanHostNewBridgeRope(Directions snapDir)
		{
			return default(bool);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00006044 File Offset: 0x00004244
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "153")]
		private bool CanHostNewClimbRope(Directions snapDir)
		{
			return default(bool);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000605C File Offset: 0x0000425C
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "157")]
		private bool CanHostSingleStep()
		{
			return default(bool);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x2E72CE0", Offset = "0x2E712E0", VA = "0x182E72CE0")]
		public FakeBeamStructure()
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00006074 File Offset: 0x00004274
		[Token(Token = "0x6000939")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}
	}
}
