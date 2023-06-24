using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x20007F7")]
	[AddComponentMenu("Gameplay/SpawnedObjectTag")]
	public class SpawnedObjectTag : MonoBehaviour
	{
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x170006D6")]
		public SpawnedObjectTag.TagType ObjectTag
		{
			[Token(Token = "0x600372B")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return SpawnedObjectTag.TagType.Log;
			}
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x3539D10", Offset = "0x3538310", VA = "0x183539D10")]
		private void OnEnable()
		{
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x3539F40", Offset = "0x3538540", VA = "0x183539F40")]
		private void OnDisable()
		{
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpawnedObjectTag()
		{
		}

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpawnedObjectTag.TagType _tag;

		// Token: 0x020007F8 RID: 2040
		[Token(Token = "0x20007F8")]
		public enum TagType
		{
			// Token: 0x04002F9E RID: 12190
			[Token(Token = "0x4002F9E")]
			Log,
			// Token: 0x04002F9F RID: 12191
			[Token(Token = "0x4002F9F")]
			Stick,
			// Token: 0x04002FA0 RID: 12192
			[Token(Token = "0x4002FA0")]
			Rock,
			// Token: 0x04002FA1 RID: 12193
			[Token(Token = "0x4002FA1")]
			Salmon,
			// Token: 0x04002FA2 RID: 12194
			[Token(Token = "0x4002FA2")]
			Bone
		}
	}
}
