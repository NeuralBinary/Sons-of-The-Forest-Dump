using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.VFX
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class DeathHitFlash : MonoBehaviour
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x3170510", Offset = "0x316EB10", VA = "0x183170510")]
		public void Play()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3170570", Offset = "0x316EB70", VA = "0x183170570")]
		public void Stop()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x3170510", Offset = "0x316EB10", VA = "0x183170510")]
		public void Restart()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x31705F0", Offset = "0x316EBF0", VA = "0x1831705F0")]
		private void Update()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3170600", Offset = "0x316EC00", VA = "0x183170600")]
		private void UpdatePlaying()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x3170850", Offset = "0x316EE50", VA = "0x183170850")]
		public DeathHitFlash()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _volumeTarget;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x30")]
		private float _elapsedTime;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x34")]
		private float _startTime;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x38")]
		private bool _hasStarted;
	}
}
