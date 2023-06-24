using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	public class BuildActionAccessories : MonoBehaviour
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x2DF2090", Offset = "0x2DF0690", VA = "0x182DF2090")]
		private void Awake()
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void Register(IEquipAccessoryListener equipAccessoryListener)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x2DF22A0", Offset = "0x2DF08A0", VA = "0x182DF22A0")]
		public void Equip(LeftHandAccessories accessory)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x2DF2340", Offset = "0x2DF0940", VA = "0x182DF2340")]
		public void Equip(RightHandAccessories accessory)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0000BF9C File Offset: 0x0000A19C
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x2DF23E0", Offset = "0x2DF09E0", VA = "0x182DF23E0")]
		public bool HasEquipped(LeftHandAccessories accessory)
		{
			return default(bool);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x2DF2560", Offset = "0x2DF0B60", VA = "0x182DF2560")]
		public bool HasEquipped(RightHandAccessories accessory)
		{
			return default(bool);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x2DF26E0", Offset = "0x2DF0CE0", VA = "0x182DF26E0")]
		private static void EquipInternal(GameObject accessoryGo, ref GameObject activeAccessoryRef)
		{
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x2DF2970", Offset = "0x2DF0F70", VA = "0x182DF2970")]
		public BuildActionAccessories()
		{
		}

		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x20")]
		[Header("Held Fakes")]
		[SerializeField]
		private GameObject _splitLog;

		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _splitQuarterLog;

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fakeStickAnimatedLeft;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _fakeStickAnimatedRight;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rightHandItemsRoot;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _leftHandAxe;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _leftHandBone;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<RightHandAccessories, GameObject> _rightHandAccessories;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<LeftHandAccessories, GameObject> _leftHandAccessories;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x68")]
		private GameObject _activeLeftHandAccessory;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x70")]
		private GameObject _activeRightHandAccessory;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x78")]
		private IEquipAccessoryListener _equipAccessoryListener;
	}
}
