using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[CreateAssetMenu(menuName = "Sons/Ai/Condition Set", fileName = "ConditionSet", order = 0)]
	public class ConditionSet : ScriptableObject
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2B204C0", Offset = "0x2B1EAC0", VA = "0x182B204C0")]
		private void OnValidate()
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2B20740", Offset = "0x2B1ED40", VA = "0x182B20740")]
		public bool MatchesConditions(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ConditionSet()
		{
		}

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Condition> _conditions;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Condition> _anyConditions;
	}
}
