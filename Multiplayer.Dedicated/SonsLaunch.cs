using System;
using Il2CppDummyDll;
using Sons.Loading;
using UnityEngine;

namespace Sons.Multiplayer.Dedicated
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class SonsLaunch : MonoBehaviour
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x245E290", Offset = "0x245C890", VA = "0x18245E290")]
		private void Start()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SonsLaunch()
		{
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoadScene _titleSceneLoader;
	}
}
