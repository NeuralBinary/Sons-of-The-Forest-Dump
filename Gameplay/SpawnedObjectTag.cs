using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006BF RID: 1727
	[Token(Token = "0x20006BF")]
	[AddComponentMenu("Gameplay/SpawnedObjectTag")]
	public class SpawnedObjectTag : MonoBehaviour
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x17000597")]
		public SpawnedObjectTag.TagType ObjectTag
		{
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return SpawnedObjectTag.TagType.Log;
			}
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0x2DF9AE0", Offset = "0x2DF8AE0", VA = "0x182DF9AE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x2DF9980", Offset = "0x2DF8980", VA = "0x182DF9980")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SpawnedObjectTag()
		{
		}

		// Token: 0x040027B2 RID: 10162
		[Token(Token = "0x40027B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpawnedObjectTag.TagType _tag;

		// Token: 0x020006C0 RID: 1728
		[Token(Token = "0x20006C0")]
		public enum TagType
		{
			// Token: 0x040027B4 RID: 10164
			[Token(Token = "0x40027B4")]
			Log,
			// Token: 0x040027B5 RID: 10165
			[Token(Token = "0x40027B5")]
			Stick,
			// Token: 0x040027B6 RID: 10166
			[Token(Token = "0x40027B6")]
			Rock,
			// Token: 0x040027B7 RID: 10167
			[Token(Token = "0x40027B7")]
			Salmon,
			// Token: 0x040027B8 RID: 10168
			[Token(Token = "0x40027B8")]
			Bone
		}
	}
}
