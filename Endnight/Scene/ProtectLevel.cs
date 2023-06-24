using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Scene
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[AddComponentMenu("Endnight/Scene/ProtectLevel")]
	public class ProtectLevel : MonoBehaviour
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA91740", Offset = "0xA8FD40", VA = "0x180A91740")]
		public bool IsBelow(ProtectLevel.Level level)
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ProtectLevel()
		{
		}

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProtectLevel.Level _level;

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		[Serializable]
		public enum Level
		{
			// Token: 0x0400018D RID: 397
			[Token(Token = "0x400018D")]
			Always
		}
	}
}
