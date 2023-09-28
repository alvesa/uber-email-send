public record SendMailRequest {
    public required string To { get; set; }
    public required string Subject { get; set; }
    public required string Message { get; set; }
}