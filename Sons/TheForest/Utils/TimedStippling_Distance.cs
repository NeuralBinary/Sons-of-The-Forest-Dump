using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	public class TimedStippling_Distance : MonoBehaviour
	{
		// Token: 0x06001A94 RID: 6804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x32A4850", Offset = "0x32A2E50", VA = "0x1832A4850")]
		private void Awake()
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x32A4B00", Offset = "0x32A3100", VA = "0x1832A4B00")]
		private void Update()
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x32A4C50", Offset = "0x32A3250", VA = "0x1832A4C50")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x32A4C60", Offset = "0x32A3260", VA = "0x1832A4C60")]
		private void OnDisable()
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x32A4C50", Offset = "0x32A3250", VA = "0x1832A4C50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x32A4C70", Offset = "0x32A3270", VA = "0x1832A4C70")]
		private void VisibilityCheck()
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x32A5140", Offset = "0x32A3740", VA = "0x1832A5140")]
		private void SetStipplingAlpha(float alpha)
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x32A5330", Offset = "0x32A3930", VA = "0x1832A5330")]
		private void BeginStipplingIn()
		{
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x32A5400", Offset = "0x32A3A00", VA = "0x1832A5400")]
		private void BeginStipplingOut()
		{
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x32A5470", Offset = "0x32A3A70", VA = "0x1832A5470")]
		private void WSRegister()
		{
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x32A55C0", Offset = "0x32A3BC0", VA = "0x1832A55C0")]
		private void WSUnregister()
		{
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x32A5640", Offset = "0x32A3C40", VA = "0x1832A5640")]
		public TimedStippling_Distance()
		{
		}

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x040019A6 RID: 6566
		[Token(Token = "0x40019A6")]
		[FieldOffset(Offset = "0x28")]
		public float _stippleOutDistance;

		// Token: 0x040019A7 RID: 6567
		[Token(Token = "0x40019A7")]
		[FieldOffset(Offset = "0x2C")]
		public float _stippleInDistance;

		// Token: 0x040019A8 RID: 6568
		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0x30")]
		private bool _isVisible;

		// Token: 0x040019A9 RID: 6569
		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0x31")]
		private bool _stipplingIn;

		// Token: 0x040019AA RID: 6570
		[Token(Token = "0x40019AA")]
		[FieldOffset(Offset = "0x34")]
		private float _alpha;

		// Token: 0x040019AB RID: 6571
		[Token(Token = "0x40019AB")]
		[FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock _block;

		// Token: 0x040019AC RID: 6572
		[Token(Token = "0x40019AC")]
		[FieldOffset(Offset = "0x40")]
		private int _wsToken;
	}
}
