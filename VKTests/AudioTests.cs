using Knfa.VK;
using Knfa.VK.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace VKTests
{
    public class AudioTests
    {
        [Fact]
        public void SearchTest()
        {
            const int count = 5;
            var api = new VkApi();

            var response = api.Execute<ItemCollection<Audio>>(Methods.Audio.Search.GetName(),
                Argument.Create("q", "Nirvana"),
                Argument.Create("count", count),
                TestsHelper.AccessToken,
                TestsHelper.ApiVersion
                ).Result;

            var audio = response.Items.First();

            TestsHelper.TraceAudioInfo(audio);

            Assert.Equal(count, response.Items.Count());
        }

        [Fact]
        public void GetByIdTest()
        {
            const int ownerId = 1;
            const int audioId = 190442705;
            var api = new VkApi();

            var response = api.Execute<IEnumerable<Audio>>(Methods.Audio.GetById.GetName(),
                Argument.Create("audios", String.Format("{0}_{1}", ownerId, audioId)),
                TestsHelper.AccessToken,
                TestsHelper.ApiVersion
                ).Result;

            var audio = response.First();

            TestsHelper.TraceAudioInfo(audio);

            Assert.Equal(ownerId, audio.OwnerId);
            Assert.Equal(audioId, audio.Id);
        }

        [Fact]
        public void GetLyricsTest()
        {
            const int lyricsId = 2428970;
            var api = new VkApi();

            var response = api.Execute<Lyrics>(Methods.Audio.GetLyrics.GetName(),
                Argument.Create("lyrics_id", lyricsId),
                TestsHelper.AccessToken,
                TestsHelper.ApiVersion
                ).Result;

            Assert.Equal(lyricsId, response.Id);
            Trace.Write(response.Text);
        }

    }
}
