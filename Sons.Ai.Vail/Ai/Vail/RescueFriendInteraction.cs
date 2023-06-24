using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[AddComponentMenu("Sons/Ai/Interact/RescueFriendInteraction")]
	public class RescueFriendInteraction : MonoBehaviour
	{
		// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2B25E90", Offset = "0x2B24490", VA = "0x182B25E90")]
		public void BeginInteraction(VailActor draggedByActor)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2B260C0", Offset = "0x2B246C0", VA = "0x182B260C0")]
		private void BeginDrag()
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2B26390", Offset = "0x2B24990", VA = "0x182B26390")]
		public void EndDrag()
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2B266F0", Offset = "0x2B24CF0", VA = "0x182B266F0")]
		private bool PlayerBehindActor(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2B26BA0", Offset = "0x2B251A0", VA = "0x182B26BA0")]
		private void Update()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2B271F0", Offset = "0x2B257F0", VA = "0x182B271F0")]
		public RescueFriendInteraction()
		{
		}

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _snapStartTime;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _startSnapDuration;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Group _rescueFriendGroup;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x30")]
		private VailActor _draggedByActor;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x38")]
		private VailActor _draggedActor;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x40")]
		private RescueFriendInteraction.DragState _dragState;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x44")]
		private float _dragStartTime;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _dragStartPos;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion _dragStartRot;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x64")]
		private readonly int DragHash;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x68")]
		private readonly int DraggedHash;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x6C")]
		private readonly int DirectionHash;

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		private enum DragState
		{
			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			None,
			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			Start,
			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			Attached
		}
	}
}
