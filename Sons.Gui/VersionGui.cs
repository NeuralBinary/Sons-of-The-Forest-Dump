using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[AddComponentMenu("Sons/Gui/VersionGui")]
	public class VersionGui : MonoBehaviour
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3021670", Offset = "0x301FC70", VA = "0x183021670")]
		private void RefreshVersionReadout()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3021670", Offset = "0x301FC70", VA = "0x183021670")]
		private void Start()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VersionGui()
		{
		}

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text _versionText;
	}
}
