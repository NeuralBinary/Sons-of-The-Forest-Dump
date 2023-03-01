using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Data
{
	// Token: 0x02000749 RID: 1865
	[Token(Token = "0x2000749")]
	[CreateAssetMenu(fileName = "NewPhysicsSfxData", menuName = "Sons/Data/PhysicsSfxData", order = 0)]
	public class PhysicsSfxData : ScriptableObject
	{
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x17000611")]
		public LayerMask SubtleImpactSfxLayerMask
		{
			[Token(Token = "0x6003088")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return default(LayerMask);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x17000612")]
		public LayerMask WaterImpactSfxLayerMask
		{
			[Token(Token = "0x6003089")]
			[Address(RVA = "0x8CDC40", Offset = "0x8CCC40", VA = "0x1808CDC40")]
			get
			{
				return default(LayerMask);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000613")]
		public string SubtleImpactSfx
		{
			[Token(Token = "0x600308A")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000614")]
		public string WoodImpactSfx
		{
			[Token(Token = "0x600308B")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000615")]
		public string WaterImpactSfx
		{
			[Token(Token = "0x600308C")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000616")]
		public string SubtleSlideSfx
		{
			[Token(Token = "0x600308D")]
			[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600308E")]
		[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
		public PhysicsSfxData()
		{
		}

		// Token: 0x04002A82 RID: 10882
		[Token(Token = "0x4002A82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask _subtleImpactSfxLayerMask;

		// Token: 0x04002A83 RID: 10883
		[Token(Token = "0x4002A83")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LayerMask _waterImpactSfxLayerMask;

		// Token: 0x04002A84 RID: 10884
		[Token(Token = "0x4002A84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _subtleImpact;

		// Token: 0x04002A85 RID: 10885
		[Token(Token = "0x4002A85")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		[SerializeField]
		private string _woodImpact;

		// Token: 0x04002A86 RID: 10886
		[Token(Token = "0x4002A86")]
		[FieldOffset(Offset = "0x30")]
		[EventRef]
		[SerializeField]
		private string _waterImpact;

		// Token: 0x04002A87 RID: 10887
		[Token(Token = "0x4002A87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _subtleSlide;
	}
}
