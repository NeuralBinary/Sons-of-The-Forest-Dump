using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[AddComponentMenu("Endnight/Utilities/Application Quit")]
	public class ApplicationQuit : MonoBehaviour
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA6C8B0", Offset = "0xA6AEB0", VA = "0x180A6C8B0")]
		public void DoQuit(string message, int code)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA6C8C0", Offset = "0xA6AEC0", VA = "0x180A6C8C0")]
		public void DoQuit(string message)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA6C8D0", Offset = "0xA6AED0", VA = "0x180A6C8D0")]
		public void DoQuit(int code)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xA6C8E0", Offset = "0xA6AEE0", VA = "0x180A6C8E0")]
		private void DoQuitInternal([Optional] string message, int code = 0)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ApplicationQuit()
		{
		}
	}
}
