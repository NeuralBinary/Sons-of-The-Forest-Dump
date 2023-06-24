using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.Mae
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public class GenerateEvent : ActionTemplate
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2D1DF90", Offset = "0x2D1C590", VA = "0x182D1DF90")]
		private bool ShouldShowIsUnique()
		{
			return default(bool);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x1700000B")]
		private bool IsUniqueStimuli
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2D1E010", Offset = "0x2D1C610", VA = "0x182D1E010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2D1E090", Offset = "0x2D1C690", VA = "0x182D1E090", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2D1E0B0", Offset = "0x2D1C6B0", VA = "0x182D1E0B0", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2D1E240", Offset = "0x2D1C840", VA = "0x182D1E240", Slot = "17")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2D1E320", Offset = "0x2D1C920", VA = "0x182D1E320")]
		public GenerateEvent()
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _eventPrefab;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_parentTo")]
		private GenerateEvent.TargetPosition _targetPosition;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("_parentToId")]
		[SerializeField]
		private string _targetPositionId;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GenerateEvent.AttachType _parent;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("Remove any existing prefab with same name")]
		[SerializeField]
		private bool _isUniqueStimuli;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x7D")]
		[SerializeField]
		private bool _proxyTargetIsLastStimuli;

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		public enum TargetPosition
		{
			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			None,
			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			ThisActor,
			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			ActorLookAtOffset,
			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			StimuliOwner,
			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			StimuliProxy
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public enum AttachType
		{
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			None,
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			ParentToTarget,
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			ConstrainPosition
		}
	}
}
