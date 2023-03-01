using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200068C RID: 1676
	[Token(Token = "0x200068C")]
	[CreateAssetMenu(menuName = "Sons/Animation/Player Expression Settings", fileName = "PlayerExpressionSettings", order = 0)]
	public class PlayerExpressionsSettings : ScriptableObject
	{
		// Token: 0x06002AE6 RID: 10982 RVA: 0x0000C558 File Offset: 0x0000A758
		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0x2DD9250", Offset = "0x2DD8250", VA = "0x182DD9250")]
		public Vector2 BlinkRate()
		{
			return default(Vector2);
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000582")]
		public List<PlayerExpressionsSettings.Expression> Expressions
		{
			[Token(Token = "0x6002AE7")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x17000583")]
		public int ExpressionCount
		{
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x2DD9500", Offset = "0x2DD8500", VA = "0x182DD9500")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x17000584")]
		public bool UseRandom
		{
			[Token(Token = "0x6002AE9")]
			[Address(RVA = "0x5A15F0", Offset = "0x5A05F0", VA = "0x1805A15F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x17000585")]
		public float WeightBlendRate
		{
			[Token(Token = "0x6002AEA")]
			[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0x2DD93B0", Offset = "0x2DD83B0", VA = "0x182DD93B0")]
		public string RandomExpressionName()
		{
			return null;
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0x2DD9490", Offset = "0x2DD8490", VA = "0x182DD9490")]
		public float RandomHoldTime()
		{
			return default(float);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x6002AED")]
		[Address(RVA = "0x2DD9450", Offset = "0x2DD8450", VA = "0x182DD9450")]
		public float RandomExpressionWeight()
		{
			return default(float);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x2DD9270", Offset = "0x2DD8270", VA = "0x182DD9270")]
		public PlayerExpressionsSettings.ExpressionEvent GetExpressionEvent(PlayerExpressionsSettings.EventType eventType)
		{
			return null;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x2DD94B0", Offset = "0x2DD84B0", VA = "0x182DD94B0")]
		public PlayerExpressionsSettings()
		{
		}

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<PlayerExpressionsSettings.Expression> _expressions;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _weightBlendRate;

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerExpressionsSettings.ExpressionEvent> _expressionEvents;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useRandom;

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _noExpressionChance;

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _expressionHoldRange;

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _expressionWeightRange;

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _blinkRate;

		// Token: 0x0200068D RID: 1677
		[Token(Token = "0x200068D")]
		[Serializable]
		public class Expression
		{
			// Token: 0x06002AF0 RID: 10992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002AF0")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public Expression()
			{
			}

			// Token: 0x04002673 RID: 9843
			[Token(Token = "0x4002673")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04002674 RID: 9844
			[Token(Token = "0x4002674")]
			[FieldOffset(Offset = "0x18")]
			public string AnimParam;
		}

		// Token: 0x0200068E RID: 1678
		[Token(Token = "0x200068E")]
		public enum EventType
		{
			// Token: 0x04002676 RID: 9846
			[Token(Token = "0x4002676")]
			AngerL1,
			// Token: 0x04002677 RID: 9847
			[Token(Token = "0x4002677")]
			AngerL2,
			// Token: 0x04002678 RID: 9848
			[Token(Token = "0x4002678")]
			FearL1,
			// Token: 0x04002679 RID: 9849
			[Token(Token = "0x4002679")]
			FearL2
		}

		// Token: 0x0200068F RID: 1679
		[Token(Token = "0x200068F")]
		[Serializable]
		public class ExpressionEvent
		{
			// Token: 0x06002AF1 RID: 10993 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
			[Token(Token = "0x6002AF1")]
			[Address(RVA = "0x2DC8EB0", Offset = "0x2DC7EB0", VA = "0x182DC8EB0")]
			public float GetTargetWeight(float eventTime)
			{
				return default(float);
			}

			// Token: 0x06002AF2 RID: 10994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002AF2")]
			[Address(RVA = "0x2DC8FC0", Offset = "0x2DC7FC0", VA = "0x182DC8FC0")]
			public ExpressionEvent()
			{
			}

			// Token: 0x0400267A RID: 9850
			[Token(Token = "0x400267A")]
			[FieldOffset(Offset = "0x10")]
			public PlayerExpressionsSettings.EventType Type;

			// Token: 0x0400267B RID: 9851
			[Token(Token = "0x400267B")]
			[FieldOffset(Offset = "0x18")]
			public string Expression;

			// Token: 0x0400267C RID: 9852
			[Token(Token = "0x400267C")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 WeightRange;

			// Token: 0x0400267D RID: 9853
			[Token(Token = "0x400267D")]
			[FieldOffset(Offset = "0x28")]
			public float CycleTime;

			// Token: 0x0400267E RID: 9854
			[Token(Token = "0x400267E")]
			[FieldOffset(Offset = "0x2C")]
			public float Time;

			// Token: 0x0400267F RID: 9855
			[Token(Token = "0x400267F")]
			[FieldOffset(Offset = "0x30")]
			public float FadeTime;
		}
	}
}
