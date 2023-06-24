using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;

namespace Endnight.Localization
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[CreateAssetMenu(fileName = "LocalizationArray", menuName = "Localization/Localization Array")]
	public class LocalizationArray : ScriptableObject
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xA80CE0", Offset = "0xA7F2E0", VA = "0x180A80CE0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xA80F90", Offset = "0xA7F590", VA = "0x180A80F90")]
		public LocalizedString Get(int i)
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000C")]
		public LocalizedString Get<T>(string value) where T : Enum
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public LocalizationArray()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _enumType;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		private string[] _enumeration;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizedString[] _values;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LocalizedString _notFoundFallback;
	}
}
