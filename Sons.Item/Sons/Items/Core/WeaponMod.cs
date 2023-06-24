using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[CreateAssetMenu(fileName = "NewWeaponMod", menuName = "Sons/Data/Items/WeaponMod")]
	public class WeaponMod : ScriptableObject
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x17000056")]
		public int Id
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x30B2350", Offset = "0x30B0950", VA = "0x1830B2350")]
		private void OnValidate()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public WeaponMod()
		{
		}

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		public GameObject ModPrefab;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(Types.Extension, true)]
		[SerializeField]
		public int ModItemId;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x24")]
		public WeaponMod.Slot AttachesToSlot;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x28")]
		public WeaponMod.Slot RequiredSlot;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _hashId;

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		public enum Slot
		{
			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			None,
			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			Rail,
			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			Muzzle,
			// Token: 0x04000203 RID: 515
			[Token(Token = "0x4000203")]
			OnTopRail,
			// Token: 0x04000204 RID: 516
			[Token(Token = "0x4000204")]
			OnBottomRail,
			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000205")]
			AmmoClip,
			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			Grip
		}
	}
}
