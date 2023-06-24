using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Serializable]
	public class TimeOfDayValuePair<T>
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		public TimeOfDayValuePair()
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal T _value;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal TimeOfDay _timeOfDay;
	}
}
