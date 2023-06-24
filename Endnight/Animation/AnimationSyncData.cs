using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[Serializable]
	public class AnimationSyncData
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		internal void SetSharedParameters(List<string> value)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		private List<string> GetParameterDropDown()
		{
			return null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA5CDA0", Offset = "0xA5B3A0", VA = "0x180A5CDA0")]
		private void UpdateDriverStateHash()
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xAAD6B0", Offset = "0xAABCB0", VA = "0x180AAD6B0")]
		private void UpdateTargetStateHash()
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xAAD710", Offset = "0xAABD10", VA = "0x180AAD710")]
		private void UpdateSyncParameterHashes()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xAAD950", Offset = "0xAABF50", VA = "0x180AAD950")]
		public AnimationSyncData(int driverLayer, int driverState, int targetLayer, int targetState)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xAAD970", Offset = "0xAABF70", VA = "0x180AAD970")]
		private void UpdateHash(string stringToHash, out int result)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xAAD9D0", Offset = "0xAABFD0", VA = "0x180AAD9D0")]
		public bool Evaluate(Animator driver, Animator target)
		{
			return default(bool);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xAADD70", Offset = "0xAAC370", VA = "0x180AADD70")]
		private void SyncTime(Animator target, AnimatorStateInfo driverStateInfo, AnimatorStateInfo targetCurrentAnimatorStateInfo)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xAADEA0", Offset = "0xAAC4A0", VA = "0x180AADEA0")]
		private float GetTimeSyncTimeOffset(AnimatorStateInfo driverCurrentStateInfo, AnimatorStateInfo targetCurrentAnimatorStateInfo, out bool mustPlay)
		{
			return 0f;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xAAE070", Offset = "0xAAC670", VA = "0x180AAE070")]
		private void SyncParameters(Animator driver, Animator target)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xAAE270", Offset = "0xAAC870", VA = "0x180AAE270")]
		private void SyncParameter(Animator driver, Animator target, int paramHash)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xAAE480", Offset = "0xAACA80", VA = "0x180AAE480")]
		public bool Validate(Animator driver, Animator target, out string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
		public void SetDriverLayer(int layerIndex)
		{
		}

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _useParameterToSyncTime;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _driverLayer;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _driverStateName;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _syncParameters;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private List<int> _syncParameterHashes;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private int _driverState;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _targetLayer;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _targetStateName;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private int _targetState;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x48")]
		private List<string> _sharedParameters;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SyncNormalizedTimeHash;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x50")]
		private float _syncTimeLagOffsetTotal;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x54")]
		private float _syncTimeLagOffsetDeltaTotal;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x58")]
		private float _syncTimeLagOffset;
	}
}
