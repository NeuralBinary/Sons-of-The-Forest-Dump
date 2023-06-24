using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Tutorials
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	[AddComponentMenu("Sons/Construction/FreeFormTutorialLoader")]
	public class FreeFormTutorialLoader : MonoBehaviour
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x2F58D40", Offset = "0x2F57340", VA = "0x182F58D40")]
		private void Start()
		{
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x2F58F60", Offset = "0x2F57560", VA = "0x182F58F60")]
		public FreeFormTutorialLoader()
		{
		}

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<ConstructionTutorial> _tutorials;
	}
}
