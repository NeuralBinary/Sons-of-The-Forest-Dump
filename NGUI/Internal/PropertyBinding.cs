using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[AddComponentMenu("NGUI/Internal/Property Binding")]
	[ExecuteInEditMode]
	public class PropertyBinding : MonoBehaviour
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x268C410", Offset = "0x268AA10", VA = "0x18268C410")]
		private void Start()
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x268C480", Offset = "0x268AA80", VA = "0x18268C480")]
		private void Update()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x268C490", Offset = "0x268AA90", VA = "0x18268C490")]
		private void LateUpdate()
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x268C4A0", Offset = "0x268AAA0", VA = "0x18268C4A0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x268C4B0", Offset = "0x268AAB0", VA = "0x18268C4B0")]
		private void OnValidate()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x268C4F0", Offset = "0x268AAF0", VA = "0x18268C4F0")]
		[ContextMenu("Update Now")]
		public void UpdateTarget()
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x268C6D0", Offset = "0x268ACD0", VA = "0x18268C6D0")]
		public PropertyBinding()
		{
		}

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x20")]
		public PropertyReference source;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x28")]
		public PropertyReference target;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x30")]
		public PropertyBinding.Direction direction;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x34")]
		public PropertyBinding.UpdateCondition update;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x38")]
		public bool editMode;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x40")]
		private object mLastValue;

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		public enum UpdateCondition
		{
			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			OnStart,
			// Token: 0x04000321 RID: 801
			[Token(Token = "0x4000321")]
			OnUpdate,
			// Token: 0x04000322 RID: 802
			[Token(Token = "0x4000322")]
			OnLateUpdate,
			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			OnFixedUpdate
		}

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		public enum Direction
		{
			// Token: 0x04000325 RID: 805
			[Token(Token = "0x4000325")]
			SourceUpdatesTarget,
			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			TargetUpdatesSource,
			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			BiDirectional
		}
	}
}
