using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[AddComponentMenu("Sons/Characters/SimpleMoverTrigger")]
	public class SimpleMoverTrigger : MonoBehaviour
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2AED5F0", Offset = "0x2AEBBF0", VA = "0x182AED5F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x1700000A")]
		private bool IsPlaying
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2AED8C0", Offset = "0x2AEBEC0", VA = "0x182AED8C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2AED940", Offset = "0x2AEBF40", VA = "0x182AED940")]
		private void TriggerAction()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2AEDAA0", Offset = "0x2AEC0A0", VA = "0x182AEDAA0")]
		public SimpleMoverTrigger()
		{
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _triggerChance;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleMoverActor _simpleMoverActor;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SurfaceMoverPath[] _surfaceMoverPath;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useActiveHours;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2Int _hourOfDayRange;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x44")]
		private bool _triggered;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x48")]
		private float _triggeredTime;
	}
}
