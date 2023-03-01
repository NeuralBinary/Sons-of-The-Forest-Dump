using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	public class TimedStippling_Pool : MonoBehaviour
	{
		// Token: 0x06001A62 RID: 6754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x2CEEBC0", Offset = "0x2CEDBC0", VA = "0x182CEEBC0")]
		private void Awake()
		{
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x2CEF060", Offset = "0x2CEE060", VA = "0x182CEF060")]
		private void Update()
		{
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x2CEED80", Offset = "0x2CEDD80", VA = "0x182CEED80")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x2CEED70", Offset = "0x2CEDD70", VA = "0x182CEED70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x2CEEDB0", Offset = "0x2CEDDB0", VA = "0x182CEEDB0")]
		public void OnSpawned()
		{
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x2CEECE0", Offset = "0x2CEDCE0", VA = "0x182CEECE0")]
		public void OnDespawned(SpawnPool pool)
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x2CEEFF0", Offset = "0x2CEDFF0", VA = "0x182CEEFF0")]
		private void SkipStippling()
		{
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x2CEEEF0", Offset = "0x2CEDEF0", VA = "0x182CEEEF0")]
		private void SetStipplingAlpha(float alpha)
		{
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x2CEF030", Offset = "0x2CEE030", VA = "0x182CEF030")]
		private void Stop()
		{
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x2CEF140", Offset = "0x2CEE140", VA = "0x182CEF140")]
		private void VisibilityCheck()
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x2CEECA0", Offset = "0x2CEDCA0", VA = "0x182CEECA0")]
		private void BeginStipplingIn()
		{
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x2CEF230", Offset = "0x2CEE230", VA = "0x182CEF230")]
		private void WSRegister()
		{
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x2CEF2F0", Offset = "0x2CEE2F0", VA = "0x182CEF2F0")]
		private void WSUnregister()
		{
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x2CEF370", Offset = "0x2CEE370", VA = "0x182CEF370")]
		public TimedStippling_Pool()
		{
		}

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x28")]
		public bool _ignoreVisibleCheck;

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x29")]
		private bool _stipplingIn;

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x2C")]
		private float _alpha;

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _block;

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x38")]
		private int _wsToken;
	}
}
