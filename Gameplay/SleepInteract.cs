using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x20006B8")]
	[AddComponentMenu("Sons/Gameplay/SleepInteract")]
	public class SleepInteract : MonoBehaviour
	{
		// Token: 0x06002C23 RID: 11299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x2DF4FC0", Offset = "0x2DF3FC0", VA = "0x182DF4FC0")]
		private void Awake()
		{
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x2DF5E50", Offset = "0x2DF4E50", VA = "0x182DF5E50")]
		private void Update()
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x2DF5260", Offset = "0x2DF4260", VA = "0x182DF5260")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x2DF5230", Offset = "0x2DF4230", VA = "0x182DF5230")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x2DF5420", Offset = "0x2DF4420", VA = "0x182DF5420")]
		private void OnValidate()
		{
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x2DF5CE0", Offset = "0x2DF4CE0", VA = "0x182DF5CE0")]
		private void UpdateSinglePlayerSleep()
		{
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x2DF5890", Offset = "0x2DF4890", VA = "0x182DF5890")]
		private void UpdateMultiplayerSleep()
		{
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x2DF5130", Offset = "0x2DF4130", VA = "0x182DF5130")]
		private void IsWaitingToSleep(bool isWaiting)
		{
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x2DF53E0", Offset = "0x2DF43E0", VA = "0x182DF53E0")]
		private void OnGrabExit()
		{
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x2DF5800", Offset = "0x2DF4800", VA = "0x182DF5800")]
		private void SetShowIcon(bool value)
		{
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x2DF54A0", Offset = "0x2DF44A0", VA = "0x182DF54A0")]
		private void RepositionIcon()
		{
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x2DF52F0", Offset = "0x2DF42F0", VA = "0x182DF52F0")]
		private void OnGrabEnter()
		{
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x2DF50E0", Offset = "0x2DF40E0", VA = "0x182DF50E0")]
		private IEnumerator DelayedCollapse()
		{
			return null;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SleepInteract()
		{
		}

		// Token: 0x0400278E RID: 10126
		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject SleepIcon;

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x28")]
		public bool BreakAfterSleep;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GrabNode _grabNode;

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minIconDistance;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _maxIconDistance;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _iconDistanceToPlayer;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0x44")]
		private bool _isWaitingToSleep;
	}
}
