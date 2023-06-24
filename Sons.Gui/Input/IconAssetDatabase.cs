using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gui.Input
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[CreateAssetMenu(menuName = "Sons/GUI/IconAssetDatabase", fileName = "IconAssetDatabase", order = 0)]
	public class IconAssetDatabase : ScriptableObject
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x3053D40", Offset = "0x3052340", VA = "0x183053D40")]
		public List<string> GetControlPathChoices()
		{
			return null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x3053F10", Offset = "0x3052510", VA = "0x183053F10")]
		private void Sort()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3054160", Offset = "0x3052760", VA = "0x183054160")]
		private void PopulateAll()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x3054220", Offset = "0x3052820", VA = "0x183054220")]
		private void PopulateMouseInputs()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x3054760", Offset = "0x3052D60", VA = "0x183054760")]
		private void PopulateKeyboardKeys()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3054CA0", Offset = "0x30532A0", VA = "0x183054CA0")]
		private void PopulateXboxInputs()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x3054D00", Offset = "0x3053300", VA = "0x183054D00")]
		private void PopulatePs4Inputs()
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x3054D60", Offset = "0x3053360", VA = "0x183054D60")]
		private void FindMappings(string replace, string replaceWith)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x3055260", Offset = "0x3053860", VA = "0x183055260")]
		public GameObject GetIcon(string path, out bool isDefaultPrefab)
		{
			return null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x30553D0", Offset = "0x30539D0", VA = "0x1830553D0")]
		public IconAssetDatabase()
		{
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		private InputActionAsset _inputActionAsset;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _defaultIconAsset;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<IconAssetSet> _iconAssetSets;
	}
}
