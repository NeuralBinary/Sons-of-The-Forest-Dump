using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[CreateAssetMenu(menuName = "Sons/Construction/AudioClipProfile", fileName = "AudioClipProfile - ")]
	public class AudioClipProfile : ScriptableObject
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000097")]
		private int EventPathId
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2D74F70", Offset = "0x2D73570", VA = "0x182D74F70")]
		public void Play(Transform targetTr)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2D74F90", Offset = "0x2D73590", VA = "0x182D74F90")]
		public void Play(Transform targetTr, bool mpSync)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2D74FB0", Offset = "0x2D735B0", VA = "0x182D74FB0")]
		public void Play(Vector3 position, bool mpSync = true)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2D74FF0", Offset = "0x2D735F0", VA = "0x182D74FF0")]
		private void PlayFMODEvent(Transform targetTr, string path, bool mpSync)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2D75370", Offset = "0x2D73970", VA = "0x182D75370")]
		private void PlayFMODEvent(Vector3 position, string path, bool mpSync)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2D756D0", Offset = "0x2D73CD0", VA = "0x182D756D0")]
		private bool TryGetEventInstance(Vector3 position, string path, out EventInstance instance)
		{
			return default(bool);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2D75970", Offset = "0x2D73F70", VA = "0x182D75970")]
		private bool TryFindEventMpId(string path)
		{
			return default(bool);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2D75A40", Offset = "0x2D74040", VA = "0x182D75A40")]
		public AudioClipProfile()
		{
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x18")]
		[EventRef]
		[SerializeField]
		private string _eventPath;
	}
}
