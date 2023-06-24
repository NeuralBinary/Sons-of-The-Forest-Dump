using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliQueries;
using Sons.Animation.Mae;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class Attention : MonoBehaviour
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2AF54F0", Offset = "0x2AF3AF0", VA = "0x182AF54F0")]
		private string TurnToString()
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2AF5560", Offset = "0x2AF3B60", VA = "0x182AF5560")]
		private string AngleThresholdString()
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2AF55D0", Offset = "0x2AF3BD0", VA = "0x182AF55D0")]
		private void SetFromRenderer()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2AF55E0", Offset = "0x2AF3BE0", VA = "0x182AF55E0")]
		private void Apply()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2AF5630", Offset = "0x2AF3C30", VA = "0x182AF5630")]
		private void ChooseExpressionFromInspector()
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700000C")]
		public bool IsLookingAtTarget
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2A1FB00", Offset = "0x2A1E100", VA = "0x182A1FB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700000D")]
		public MonoBehaviourStimuli TargetStimuli
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2AF5640", Offset = "0x2AF3C40", VA = "0x182AF5640")]
		private static StimuliQueryNear CreateStimuliQuery(string stimuliId)
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2AF5A70", Offset = "0x2AF4070", VA = "0x182AF5A70")]
		private static void InitStimuliQueries()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2AF5C00", Offset = "0x2AF4200", VA = "0x182AF5C00")]
		public void Tick(VailActor actor, Animator animator)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2AF61E0", Offset = "0x2AF47E0", VA = "0x182AF61E0")]
		private void UpdateLookAt(VailActor actor)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2AF66F0", Offset = "0x2AF4CF0", VA = "0x182AF66F0")]
		public float GetAttentionWeight()
		{
			return 0f;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2AF6710", Offset = "0x2AF4D10", VA = "0x182AF6710")]
		private Attention.FrequencyByDistance GetDistanceSettings(float distance)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2AF68B0", Offset = "0x2AF4EB0", VA = "0x182AF68B0")]
		private void UpdateBlink(Animator animator, VailActor actor)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2AF6A60", Offset = "0x2AF5060", VA = "0x182AF6A60")]
		private void StartLookingAtTarget()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2AF6B30", Offset = "0x2AF5130", VA = "0x182AF6B30")]
		private void StopLookingAtTarget()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2AF6BE0", Offset = "0x2AF51E0", VA = "0x182AF6BE0")]
		private bool IsOnCooldown()
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2AF6C40", Offset = "0x2AF5240", VA = "0x182AF6C40")]
		private bool LookDurationFinished()
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2AF6CA0", Offset = "0x2AF52A0", VA = "0x182AF6CA0")]
		private static float GetCooldownDuration(Attention.Frequency frequency)
		{
			return 0f;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
		public void SetFrequency(Attention.Frequency frequency)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2AF6E80", Offset = "0x2AF5480", VA = "0x182AF6E80")]
		public void SetExpression(Attention.Expression expression)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2AF7030", Offset = "0x2AF5630", VA = "0x182AF7030")]
		private float ExpressionTime()
		{
			return 0f;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2AF7090", Offset = "0x2AF5690", VA = "0x182AF7090")]
		public void SetOverride(Attention.Expression expression, Attention.Frequency frequency)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2AF70A0", Offset = "0x2AF56A0", VA = "0x182AF70A0")]
		public void ClearOverride()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2AF70B0", Offset = "0x2AF56B0", VA = "0x182AF70B0")]
		private void SetExpressionFromStimuli(VailActor actor, MonoBehaviourStimuli stimuli)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2AF7570", Offset = "0x2AF5B70", VA = "0x182AF7570")]
		private void UpdateExpressions(Animator animator)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2AF7A80", Offset = "0x2AF6080", VA = "0x182AF7A80")]
		private void ClearExpressionWeights()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2AF7BC0", Offset = "0x2AF61C0", VA = "0x182AF7BC0")]
		private Attention.ExpressionBlends GetActiveExpression()
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2AF7D10", Offset = "0x2AF6310", VA = "0x182AF7D10")]
		public int GetActiveExpressionIndex()
		{
			return 0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2AF7DB0", Offset = "0x2AF63B0", VA = "0x182AF7DB0")]
		public void SetActiveExpression(int index)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2AF7E70", Offset = "0x2AF6470", VA = "0x182AF7E70")]
		private Attention.ExpressionBlends GetExpression(Attention.Expression expression)
		{
			return null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2AF7FC0", Offset = "0x2AF65C0", VA = "0x182AF7FC0")]
		private void SetExpressionFromRenderer()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2AF8180", Offset = "0x2AF6780", VA = "0x182AF8180")]
		private void ApplyExpression(Attention.ExpressionBlends expression)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2AF81C0", Offset = "0x2AF67C0", VA = "0x182AF81C0")]
		public Attention()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BlinkAnimHash;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _turnTo;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 180f)]
		private float _angleThreshold;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Attention.Frequency _frequency;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Attention.FrequencyByDistance> _frequencyByDistance;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _lookDurationRange;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x40")]
		private float _lookDuration;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x44")]
		private float _cooldownDuration;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x8")]
		private static StimuliQueryNear _stimuliQueryEnemyNear;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x10")]
		private static StimuliQueryNear _stimuliQueryFriendNear;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x48")]
		private MonoBehaviourStimuli _targetStimuli;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x50")]
		private float _lastTargetQueryTime;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Attention.Expression _expression;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _blendshapeIndexStart;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _blendshapeIndexEnd;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Attention.ExpressionBlends> _expressionBlends;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 _expressionTimeMinMax;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector2 _expressionCooldownMinMax;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _shouldBlink;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector2 _blinkRate;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x94")]
		private float _lastBlinkTime;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x98")]
		private float _nextBlinkTime;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x9C")]
		private bool _isLookingAtTarget;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xA0")]
		private float _startLookTime;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xA4")]
		private float _stopLookTime;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xA8")]
		private float _startExpressionTime;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0xAC")]
		private float _expressionDuration;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0xB0")]
		private bool _expressionOverride;

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public enum Frequency
		{
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			Constant,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			Rare,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			Occasional,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			First
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		[Serializable]
		internal class FrequencyByDistance
		{
			// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public FrequencyByDistance()
			{
			}

			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x10")]
			public float _distance;

			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x14")]
			public Attention.Frequency _frequency;
		}

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public enum Expression
		{
			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			Neutral,
			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			Happy,
			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			Sad,
			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			Scared,
			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			Angry
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		[Serializable]
		private class ExpressionBlends
		{
			// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2AF8440", Offset = "0x2AF6A40", VA = "0x182AF8440")]
			public void ApplyToMesh(SkinnedMeshRenderer meshRenderer, float weight)
			{
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x000025B0 File Offset: 0x000007B0
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2AF8680", Offset = "0x2AF6C80", VA = "0x182AF8680")]
			public bool IsOnCooldown()
			{
				return default(bool);
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2AF86E0", Offset = "0x2AF6CE0", VA = "0x182AF86E0")]
			private IEnumerable AnimVarParameters()
			{
				return null;
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2AF8730", Offset = "0x2AF6D30", VA = "0x182AF8730")]
			public ExpressionBlends()
			{
			}

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x10")]
			public Attention.Expression _expression;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x18")]
			public AnimationParameter _animParam;

			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x48")]
			[HideInInspector]
			public float _speed;

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x50")]
			public List<Attention.ExpressionBlends.IndexWeight> _indiceWeights;

			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0x58")]
			[HideInInspector]
			public float _weight;

			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0x5C")]
			[HideInInspector]
			public bool _active;

			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public float _expressionCooldownTime;

			// Token: 0x02000025 RID: 37
			[Token(Token = "0x2000025")]
			[Serializable]
			public struct IndexWeight
			{
				// Token: 0x040000F2 RID: 242
				[Token(Token = "0x40000F2")]
				[FieldOffset(Offset = "0x0")]
				public int _index;

				// Token: 0x040000F3 RID: 243
				[Token(Token = "0x40000F3")]
				[FieldOffset(Offset = "0x4")]
				[Range(0f, 100f)]
				public float _weight;
			}
		}
	}
}
