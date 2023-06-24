using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[CreateAssetMenu(fileName = "NewWeaponModsData", menuName = "Sons/Data/Items/WeaponModsData", order = 0)]
	public class WeaponModsData : ScriptableObject
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000057")]
		public List<WeaponMod> WeaponMods
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x30B2390", Offset = "0x30B0990", VA = "0x1830B2390")]
		public WeaponModsData()
		{
		}

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<WeaponMod> _weaponMods;
	}
}
