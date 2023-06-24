using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[CreateAssetMenu(fileName = "skinned cloth blueprint", menuName = "Obi/Skinned Cloth Blueprint", order = 122)]
	public class ObiSkinnedClothBlueprint : ObiClothBlueprint
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x17000034")]
		public override bool usesTethers
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2746DD0", Offset = "0x27453D0", VA = "0x182746DD0", Slot = "17")]
		protected override IEnumerator Initialize()
		{
			return null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2746E60", Offset = "0x2745460", VA = "0x182746E60")]
		protected IEnumerator CreateSkinConstraints()
		{
			return null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2741FD0", Offset = "0x27405D0", VA = "0x182741FD0")]
		public ObiSkinnedClothBlueprint()
		{
		}
	}
}
