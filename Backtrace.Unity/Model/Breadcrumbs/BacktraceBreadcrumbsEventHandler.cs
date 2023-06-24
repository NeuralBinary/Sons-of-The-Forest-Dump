using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	internal sealed class BacktraceBreadcrumbsEventHandler
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00002E1C File Offset: 0x0000101C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000087")]
		public bool HasRegisteredEvents
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x75DF70", Offset = "0x75C570", VA = "0x18075DF70")]
		public BacktraceBreadcrumbsEventHandler(BacktraceBreadcrumbs breadcrumbs)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x75E040", Offset = "0x75C640", VA = "0x18075E040")]
		public void Register(BacktraceBreadcrumbType level)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x75E430", Offset = "0x75CA30", VA = "0x18075E430")]
		public void Unregister()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x75E820", Offset = "0x75CE20", VA = "0x18075E820")]
		private void SceneManager_sceneUnloaded(Scene scene)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x75E8E0", Offset = "0x75CEE0", VA = "0x18075E8E0")]
		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x75EA80", Offset = "0x75D080", VA = "0x18075EA80")]
		private void HandleSceneChanged(Scene sceneFrom, Scene sceneTo)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x75ED70", Offset = "0x75D370", VA = "0x18075ED70")]
		private void HandleLowMemory()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x75EDE0", Offset = "0x75D3E0", VA = "0x18075EDE0")]
		private void HandleApplicationQuitting()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x75EE50", Offset = "0x75D450", VA = "0x18075EE50")]
		private void HandleBackgroundMessage(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x75EFC0", Offset = "0x75D5C0", VA = "0x18075EFC0")]
		private void HandleMessage(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x75F120", Offset = "0x75D720", VA = "0x18075F120")]
		private void Application_focusChanged(bool hasFocus)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x75F260", Offset = "0x75D860", VA = "0x18075F260")]
		private void Log(string message, LogType level, BreadcrumbLevel breadcrumbLevel, [Optional] IDictionary<string, string> attributes)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x75F2E0", Offset = "0x75D8E0", VA = "0x18075F2E0")]
		private void LogNewNetworkStatus(NetworkReachability status)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x75F390", Offset = "0x75D990", VA = "0x18075F390")]
		internal void Update()
		{
		}

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly BacktraceBreadcrumbs _breadcrumbs;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BacktraceBreadcrumbType _registeredLevel;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private NetworkReachability _networkStatus;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Thread _thread;
	}
}
