using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	[CreateAssetMenu(menuName = "Sons/Animation/Player Expression Settings", fileName = "PlayerExpressionSettings", order = 0)]
	public class PlayerExpressionsSettings : ScriptableObject
	{
		// Token: 0x06003557 RID: 13655 RVA: 0x0000FF60 File Offset: 0x0000E160
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x34DEF30", Offset = "0x34DD530", VA = "0x1834DEF30")]
		public Vector2 BlinkRate()
		{
			return default(Vector2);
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B5")]
		public List<PlayerExpressionsSettings.Expression> Expressions
		{
			[Token(Token = "0x6003558")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x0000FF78 File Offset: 0x0000E178
		[Token(Token = "0x170006B6")]
		public int ExpressionCount
		{
			[Token(Token = "0x6003559")]
			[Address(RVA = "0x34DEF50", Offset = "0x34DD550", VA = "0x1834DEF50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x0000FF90 File Offset: 0x0000E190
		[Token(Token = "0x170006B7")]
		public bool UseRandom
		{
			[Token(Token = "0x600355A")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x170006B8")]
		public float WeightBlendRate
		{
			[Token(Token = "0x600355B")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x34DEF90", Offset = "0x34DD590", VA = "0x1834DEF90")]
		public string RandomExpressionName()
		{
			return null;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x34DF060", Offset = "0x34DD660", VA = "0x1834DF060")]
		public float RandomHoldTime()
		{
			return 0f;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x34DF080", Offset = "0x34DD680", VA = "0x1834DF080")]
		public float RandomExpressionWeight()
		{
			return 0f;
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x34DF0C0", Offset = "0x34DD6C0", VA = "0x1834DF0C0")]
		public PlayerExpressionsSettings.ExpressionEvent GetExpressionEvent(PlayerExpressionsSettings.EventType eventType)
		{
			return null;
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x34DF210", Offset = "0x34DD810", VA = "0x1834DF210")]
		public PlayerExpressionsSettings()
		{
		}

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<PlayerExpressionsSettings.Expression> _expressions;

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _weightBlendRate;

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerExpressionsSettings.ExpressionEvent> _expressionEvents;

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useRandom;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _noExpressionChance;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _expressionHoldRange;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _expressionWeightRange;

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _blinkRate;

		// Token: 0x020007B8 RID: 1976
		[Token(Token = "0x20007B8")]
		[Serializable]
		public class Expression
		{
			// Token: 0x06003561 RID: 13665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003561")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Expression()
			{
			}

			// Token: 0x04002E14 RID: 11796
			[Token(Token = "0x4002E14")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04002E15 RID: 11797
			[Token(Token = "0x4002E15")]
			[FieldOffset(Offset = "0x18")]
			public string AnimParam;
		}

		// Token: 0x020007B9 RID: 1977
		[Token(Token = "0x20007B9")]
		public enum EventType
		{
			// Token: 0x04002E17 RID: 11799
			[Token(Token = "0x4002E17")]
			AngerL1,
			// Token: 0x04002E18 RID: 11800
			[Token(Token = "0x4002E18")]
			AngerL2,
			// Token: 0x04002E19 RID: 11801
			[Token(Token = "0x4002E19")]
			FearL1,
			// Token: 0x04002E1A RID: 11802
			[Token(Token = "0x4002E1A")]
			FearL2
		}

		// Token: 0x020007BA RID: 1978
		[Token(Token = "0x20007BA")]
		[Serializable]
		public class ExpressionEvent
		{
			// Token: 0x06003562 RID: 13666 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
			[Token(Token = "0x6003562")]
			[Address(RVA = "0x34DF260", Offset = "0x34DD860", VA = "0x1834DF260")]
			public float GetTargetWeight(float eventTime)
			{
				return 0f;
			}

			// Token: 0x06003563 RID: 13667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003563")]
			[Address(RVA = "0x34DF370", Offset = "0x34DD970", VA = "0x1834DF370")]
			public ExpressionEvent()
			{
			}

			// Token: 0x04002E1B RID: 11803
			[Token(Token = "0x4002E1B")]
			[FieldOffset(Offset = "0x10")]
			public PlayerExpressionsSettings.EventType Type;

			// Token: 0x04002E1C RID: 11804
			[Token(Token = "0x4002E1C")]
			[FieldOffset(Offset = "0x18")]
			public string Expression;

			// Token: 0x04002E1D RID: 11805
			[Token(Token = "0x4002E1D")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 WeightRange;

			// Token: 0x04002E1E RID: 11806
			[Token(Token = "0x4002E1E")]
			[FieldOffset(Offset = "0x28")]
			public float CycleTime;

			// Token: 0x04002E1F RID: 11807
			[Token(Token = "0x4002E1F")]
			[FieldOffset(Offset = "0x2C")]
			public float Time;

			// Token: 0x04002E20 RID: 11808
			[Token(Token = "0x4002E20")]
			[FieldOffset(Offset = "0x30")]
			public float FadeTime;
		}
	}
}
