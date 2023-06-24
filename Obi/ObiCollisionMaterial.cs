using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	[CreateAssetMenu(fileName = "collision material", menuName = "Obi/Collision Material", order = 180)]
	public class ObiCollisionMaterial : ScriptableObject
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000EE")]
		public ObiCollisionMaterialHandle handle
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x27CE1A0", Offset = "0x27CC7A0", VA = "0x1827CE1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x27CE1C0", Offset = "0x27CC7C0", VA = "0x1827CE1C0")]
		public void OnEnable()
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x27CE1D0", Offset = "0x27CC7D0", VA = "0x1827CE1D0")]
		public void OnDisable()
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x27CE1C0", Offset = "0x27CC7C0", VA = "0x1827CE1C0")]
		public void OnValidate()
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x27CE200", Offset = "0x27CC800", VA = "0x1827CE200")]
		public void UpdateMaterial()
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x27CE310", Offset = "0x27CC910", VA = "0x1827CE310")]
		protected void CreateMaterialIfNeeded()
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ObiCollisionMaterial()
		{
		}

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x18")]
		protected ObiCollisionMaterialHandle materialHandle;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x20")]
		public float dynamicFriction;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x24")]
		public float staticFriction;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x28")]
		public float stickiness;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x2C")]
		public float stickDistance;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x30")]
		public Oni.MaterialCombineMode frictionCombine;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x34")]
		public Oni.MaterialCombineMode stickinessCombine;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x38")]
		[Space]
		public bool rollingContacts;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x3C")]
		[VisibleIf("rollingContacts", false)]
		[Indent]
		public float rollingFriction;
	}
}
