using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Data
{
	// Token: 0x02000653 RID: 1619
	[Token(Token = "0x2000653")]
	[CreateAssetMenu(fileName = "NewPhysicsSfxData", menuName = "Sons/Data/PhysicsSfxData", order = 0)]
	public class PhysicsSfxData : ScriptableObject
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x1700057C")]
		public LayerMask SubtleImpactSfxLayerMask
		{
			[Token(Token = "0x60029E3")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return default(LayerMask);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x1700057D")]
		public LayerMask WaterImpactSfxLayerMask
		{
			[Token(Token = "0x60029E4")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return default(LayerMask);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057E")]
		public string SubtleImpactSfx
		{
			[Token(Token = "0x60029E5")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057F")]
		public string WoodImpactSfx
		{
			[Token(Token = "0x60029E6")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000580")]
		public string WaterImpactSfx
		{
			[Token(Token = "0x60029E7")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000581")]
		public string SubtleSlideSfx
		{
			[Token(Token = "0x60029E8")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public PhysicsSfxData()
		{
		}

		// Token: 0x04002548 RID: 9544
		[Token(Token = "0x4002548")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask _subtleImpactSfxLayerMask;

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LayerMask _waterImpactSfxLayerMask;

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0x20")]
		[EventRef]
		[SerializeField]
		private string _subtleImpact;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		[SerializeField]
		private string _woodImpact;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x30")]
		[EventRef]
		[SerializeField]
		private string _waterImpact;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x38")]
		[EventRef]
		[SerializeField]
		private string _subtleSlide;
	}
}
