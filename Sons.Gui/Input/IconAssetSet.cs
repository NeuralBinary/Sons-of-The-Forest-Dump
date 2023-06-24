using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Input
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Serializable]
	internal class IconAssetSet
	{
		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public IconAssetSet()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public IconAssetSet(string path, [Optional] GameObject iconAsset)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetControlPath()
		{
			return null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public void SetIcon(GameObject icon)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public GameObject GetIcon()
		{
			return null;
		}

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _controlPath;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _iconAsset;
	}
}
