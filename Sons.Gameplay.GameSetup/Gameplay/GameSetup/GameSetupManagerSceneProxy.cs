using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class GameSetupManagerSceneProxy : MonoBehaviour
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000013")]
		public GameSetupManager Instance
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2FF41F0", Offset = "0x2FF27F0", VA = "0x182FF41F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2FF4280", Offset = "0x2FF2880", VA = "0x182FF4280")]
		public void ClearSetMode()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2FF4350", Offset = "0x2FF2950", VA = "0x182FF4350")]
		public void SetMode(string modeString)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GameSetupManagerSceneProxy()
		{
		}
	}
}
