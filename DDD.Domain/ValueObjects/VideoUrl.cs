using DDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record VideoUrl
{
	public string Value { get; }

	public VideoUrl(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new VideoUrlNullOrEmptyException();
		}

		if (!value.EndsWith(".mp4"))
		{
			throw new InvalidVideoException();
		}

		Value = value;
	}

	public static implicit operator string(VideoUrl videoUrl) => videoUrl.Value;
	public static implicit operator VideoUrl(string videoUrl) => new(videoUrl);
}
