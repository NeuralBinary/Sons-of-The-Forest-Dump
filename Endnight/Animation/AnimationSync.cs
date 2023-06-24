using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class AnimationSync : MonoBehaviour, IAnimatorMoveProxyReceiver
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0xAAC700", Offset = "0xAAAD00", VA = "0x180AAC700")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600049D")]
		[Address(RVA = "0xAAC7E0", Offset = "0xAAADE0", VA = "0x180AAC7E0")]
		internal static AnimatorControllerParameter GetParameter(Animator driver, int eachHash)
		{
			return null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0xAAC900", Offset = "0xAAAF00", VA = "0x180AAC900")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0xAACB30", Offset = "0xAAB130", VA = "0x180AACB30")]
		public void SetDriver(Animator driver)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xAACF30", Offset = "0xAAB530", VA = "0x180AACF30")]
		private void RevalidateSyncData()
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xAAD3D0", Offset = "0xAAB9D0", VA = "0x180AAD3D0")]
		public void Add(AnimationSyncData animationSyncData)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xAAD500", Offset = "0xAABB00", VA = "0x180AAD500")]
		public void SetAllDriverLayer(int layerIndex)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xAAD640", Offset = "0xAABC40", VA = "0x180AAD640", Slot = "4")]
		public void OnAnimatorMove()
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimationSync()
		{
		}

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _driver;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _target;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<AnimationSyncData> _data;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x38")]
		private AnimatorMoveProxy _driverMoveProxyInstance;
	}
}
