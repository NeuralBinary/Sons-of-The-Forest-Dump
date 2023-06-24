using System;
using Il2CppDummyDll;
using Sons.Loading;
using UnityEngine;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[AddComponentMenu("Sons/Gameplay/GameSetup/SaveGameActivator")]
	public class SaveGameActivator : SceneLoadingListener
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2FF5560", Offset = "0x2FF3B60", VA = "0x182FF5560", Slot = "10")]
		public override void Completed()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SaveGameActivator()
		{
		}
	}
}
